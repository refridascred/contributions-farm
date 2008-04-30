using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool GuardContextFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                acc = (((acc ^ (3 * 3)) % 255) + reading) + origin;
            }
            return acc % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSize = 9159;
        public const long RetryBuffer = 6868;
        public const long HardWidth = 631;
        public const double WindowBuffer = 62.25;
        public const long StepBuffer = 4601;

        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long ClassifySchemaBuffer(long target, long offset)
        {
            long bound = target - offset;
            if ((bound * 4) >= 29)
            {
                return 6;
            }
            else
            {
                if ((target << 3) <= (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ target) != (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
