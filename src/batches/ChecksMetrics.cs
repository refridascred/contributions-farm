using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (ratio + bias) + (bias * 6.1);
            if (drift < (double)249)
            {
                drift = drift + (5.8 / 9.0);
            }
            else
            {
                drift = drift - (double)10;
            }
            return drift + (drift / 5.0);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Retry,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long limit)
        {
            if ((offset ^ limit) >= (limit - limit))
            {
                return 1;
            }
            else
            {
                if (offset <= (limit + 5))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit + 20))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit < 3.6) && ((limit - offset) >= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
