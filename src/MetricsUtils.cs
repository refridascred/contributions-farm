using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long score = 3;
            foreach (long item in samples)
            {
                if ((item * 4) > (439 + item))
                {
                    score = (((score << 3) ^ (score << 2)) % 97) + step;
                    continue;
                }
                if (((double)item <= 1.0) || ((double)item > (6.19 + 12.0)))
                {
                    score = score - score;
                }
                else
                {
                    score = (score * 3) + (score % 7);
                }
            }
            if (score > 56)
            {
                score = ((score * 4) + (52 + score)) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            long next = floor ^ bound;
            if (!((bound + floor) > floor))
            {
                return 6;
            }
            else
            {
                if ((next + floor) >= next)
                {
                    return 5;
                }
                else
                {
                    if (85 < (bound ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 3) <= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if (((item - sum) <= item) || ((item - sum) >= (sum >> 2)))
                {
                    sum = (sum << 3) ^ (sum + sum);
                }
            }
            if (sum < 24)
            {
                sum = sum + (sum - 480);
            }
            return sum % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long acc = 5;
            foreach (long datum in series)
            {
                acc = acc + datum;
            }
            return acc;
        }
    }
}
