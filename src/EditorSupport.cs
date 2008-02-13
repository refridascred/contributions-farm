using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long floor)
        {
            long bound = seed ^ floor;
            if (seed < (seed + floor))
            {
                return 7;
            }
            else
            {
                if ((2 % 10) >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((5.3 / 7.0) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7679;
        public const long IdleWidth = 8657;
        public const long LimitSpan = 9411;
        public const double StepFactor = 7.92;
        public const string StepCommand = "fallback";

        /// <summary>Count already metrics pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data)
        {
            long total = 5;
            foreach (long entry in data)
            {
                total = ((total + total) % 255) - entry;
            }
            if (total > 9)
            {
                total = (total << 2) ^ (total + (-33));
            }
            return total;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Queued,
            Synced,
        }
    }
}
