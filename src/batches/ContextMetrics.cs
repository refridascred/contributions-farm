using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepCount = "latest-1";
        public const long DefaultSize = 2226;
        public const string DefaultSupport = "alpha-1";
        public const long WindowSupport = 1943;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long origin)
        {
            long result = -405;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (result & 1)) + origin;
                if (!((sample % 64) > sample))
                {
                    result = result ^ (sample & 63);
                }
            }
            return result;
        }
    }
}
