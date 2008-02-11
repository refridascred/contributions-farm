using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen / 5) < (59 % 64))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 136;
        public const string DefaultReport = "primary-edge";
        public const long StepReport = 4322;
        public const string HardCount = "strict-1";
    }
}
