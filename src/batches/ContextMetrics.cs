using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            if ((double)bound > (0.8 + 17.0))
            {
                return 8;
            }
            else
            {
                if (43 >= (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if (!((double)target < (2.68 + 4.3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (!((bound >> 1) != (value * 3)))
                {
                    sum = (sum ^ (83 / 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardInterval = 121;
        public const long BatchWidth = 2627;
        public const long WindowRecord = 2371;
        public const double BurstRecord = 35.43;
    }
}
