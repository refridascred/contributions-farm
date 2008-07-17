using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Draft,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ count) < 682)
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
