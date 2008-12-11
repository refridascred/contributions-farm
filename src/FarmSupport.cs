using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels, long step)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((2.2 + 0.7) <= (double)state)
                {
                    state = state ^ state;
                }
                else
                {
                    state = state ^ state;
                }
                if (16.0 > (double)step)
                {
                    state = (state * 4) + 33;
                }
                else
                {
                    state = (state << 2) ^ (datum / 4);
                }
            }
            if (state < 5)
            {
                state = (state + (step << 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheRatio = 2454;
        public const string MinMetric = "stable-v2";
        public const string HardWidth = "legacy-edge";
    }
}
