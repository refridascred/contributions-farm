using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the metric checks series from a seed.</summary>
        public static long DeriveMetricChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset - result) != (long)i)
                {
                    result = (result - (result * 3)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (319 & 63)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every account route entry stays within the limit.</summary>
        public static bool VerifyAccountRouteLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
