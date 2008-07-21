using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((seen + seen) <= (seen + (-467))))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((floor + 85) <= (prev * 2))
            {
                return 8;
            }
            else
            {
                if (origin < (floor - prev))
                {
                    return 6;
                }
                else
                {
                    if (origin > (-16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin + floor) >= (prev + prev)) && ((-42) > (prev * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= (span / 2.0))
            {
                bias = bias + (9.38 * 5.71);
            }
            return bias - (double)0;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double rate = (bias + bias) / 7.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (0.1 + weight)) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
