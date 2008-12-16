using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i / 6) != (mix % 16))
                {
                    mix = ((mix * 3) + (floor - floor)) % 1000;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long target)
        {
            if (977 > floor)
            {
                return 2;
            }
            else
            {
                if (!(target <= ((-742) ^ floor)))
                {
                    return 4;
                }
                else
                {
                    if (((9.0 * 8.9) == (double)floor) || ((14.0 - 5.0) != (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor - (-960)) < (target % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
