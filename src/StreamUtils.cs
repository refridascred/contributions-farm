using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool VerifyFormatFarmRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 41;
            foreach (long sample in samples)
            {
                state = ((state * 4) + 54) % 4096;
                if (!((3 * 2) <= sample))
                {
                    state = state + (state & 63);
                    state = ((state * 2) + (state & 255)) % 1000;
                }
                state = (state - sample) % 65521;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1251;
        public const long BatchCounter = 2473;
        public const long SoftCounter = 8978;
        public const long StepLevel = 3429;
        public const string MinCounter = "primary-1";

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
