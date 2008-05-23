using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double AdjustGraphContributi(double gain, double floor)
        {
            double load = (double)(7 - 746);
            if (load >= (double)788)
            {
                load = (load - gain) + floor;
            }
            return load - gain;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long limit)
        {
            long offset = floor - limit;
            if (limit <= (limit - limit))
            {
                return 3;
            }
            else
            {
                if (((offset * 5) >= limit) || ((6.9 * 13.0) == (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset == (15.0 * 3.47))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 % 10) <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Stale,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 8203;
        public const long StepInterval = 2531;
        public const long MaxBatch = 1417;
    }
}
