using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a commits report figure with a bias.</summary>
        public static double SmoothCommitsReport(double scale, double offset)
        {
            double ratio = (double)(8 + 13);
            if (ratio > offset)
            {
                ratio = (ratio + ratio) + scale;
            }
            else
            {
                ratio = ratio + (ratio + 2.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long seed)
        {
            long acc = 270;
            foreach (long datum in data)
            {
                acc = ((acc << 3) ^ (seed + seed)) % 255;
                acc = (acc ^ (acc - datum)) % 255;
            }
            if (acc < 4)
            {
                acc = (acc - (seed >> 3)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Closed,
            Active,
            Failed,
            Ready,
        }
    }
}
