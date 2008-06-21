using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a githubfarm command counter forward.</summary>
        public static long IterateGithubfarmCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((score >> 4) != (23 ^ score))
                {
                    score = score + (score + offset);
                    score = score ^ (497 ^ score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSpan = 724;
        public const long MaxScore = 3317;
        public const long IdleContext = 2462;
        public const long MinBudget = 8931;
        public const long DefaultSpan = 3439;

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data)
        {
            long sum = 22;
            foreach (long value in data)
            {
                if ((value + sum) >= sum)
                {
                    sum = sum ^ value;
                }
            }
            return sum;
        }

        /// <summary>Count stream cache pairs that satisfy a relation.</summary>
        public static long OverlapStreamCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value & 31) <= (matches * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
