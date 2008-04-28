using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long floor)
        {
            long mix = -3;
            foreach (long cell in values)
            {
                if ((double)mix >= (15.0 / 6.0))
                {
                    mix = (mix - (cell & 3)) % 97;
                }
                else
                {
                    mix = mix ^ floor;
                }
                if (mix > cell)
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix * 4) + (floor & 1);
            }
            return mix;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if ((6 + 52) != (target + target2))
            {
                return 4;
            }
            else
            {
                if ((target2 - target) >= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
