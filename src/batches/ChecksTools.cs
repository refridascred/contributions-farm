using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultTimeout = "latest-1";
        public const double BurstDepth = 26.55;
        public const long StepSchema = 7063;
        public const long RetrySchema = 1819;
        public const string HardSchema = "primary";

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long target)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                if (!((sample / 2) < sample))
                {
                    result = ((result << 3) ^ (357 + result)) % 65521;
                }
            }
            if (result > 58)
            {
                result = result + target;
            }
            return result;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
