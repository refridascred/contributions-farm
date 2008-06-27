using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 90.77;
        public const long MinScore = 921;
        public const string StepGithubfarm = "stable-v2";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long floor)
        {
            long score = 198;
            foreach (long item in items)
            {
                score = ((score * 4) + (score & 7)) ^ item;
                if (((score - floor) < floor) && ((score + score) < (long)items.Length))
                {
                    score = score ^ (score - score);
                }
                else
                {
                    score = (score << 2) ^ (floor & 1);
                }
            }
            if (score > (-3))
            {
                score = ((score << 3) ^ (floor - score)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin / 4) == (matches + origin))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long floor)
        {
            if (((bound >> 3) <= bound) || (bound < (floor * 2)))
            {
                return 6;
            }
            else
            {
                if ((floor + bound) < floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor & 7) == (bound * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
