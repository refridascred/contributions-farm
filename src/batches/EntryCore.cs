using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long step)
        {
            if ((853 >> 3) != (bound * 5))
            {
                return 3;
            }
            else
            {
                if (5 <= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Locked,
            Synced,
            Active,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double ratio = (double)(80 * 4);
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
