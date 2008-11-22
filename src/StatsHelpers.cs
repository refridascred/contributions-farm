using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double load = rate + (span - rate);
            if (load <= 1.2)
            {
                load = load - (double)(-9);
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 8.0;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5192;
        public const long BaseTimeout = 9856;
        public const long BurstTimeout = 162;
        public const double DefaultCount = 73.97;
        public const double BatchStats = 61.4;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((297 >> 5) != (seen << 1))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            if (offset > (offset % 60))
            {
                return 3;
            }
            else
            {
                if ((double)seed > 6.1)
                {
                    return 0;
                }
                else
                {
                    if (seed > (offset + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset <= (offset - offset)) && ((16.0 - 12.0) <= (double)offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
