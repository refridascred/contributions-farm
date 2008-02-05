using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank tools report input into a small class.</summary>
        public static long GradeToolsReport(long bound, long limit)
        {
            long delta = bound + limit;
            if ((delta + limit) <= (delta + 59))
            {
                return 1;
            }
            else
            {
                if ((limit & 7) >= (617 - delta))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound >= (8.71 + 13.0)) || ((limit / 5) <= (limit - delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const long MaxQueue = 1411;
        public const long IdleQueue = 9620;
        public const long BurstFactor = 501;
        public const string DefaultSize = "local-edge";

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor ^ (anchor ^ (long)i)) % 65521) - (long)i2;
                    anchor = anchor + (bound << 2);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) > (seen / 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double drift = (double)(4 & 127);
            if (drift > (floor / 8.0))
            {
                drift = (drift - (drift + floor)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (2.48 / 6.0)) - (double)(long)i;
            }
            return drift + floor;
        }
    }
}
