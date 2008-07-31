using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long seed, long offset)
        {
            if ((offset << 3) == (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((offset / 8) <= (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if (seed < (seed >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double bias, double bias2)
        {
            double ratio = bias2 + 8.26;
            if (ratio > ratio)
            {
                ratio = ratio - bias2;
            }
            return ratio - (bias2 + bias);
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Stale,
            Done,
        }
    }
}
