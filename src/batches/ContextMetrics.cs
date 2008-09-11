using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ anchor;
                anchor = anchor + anchor;
                anchor = ((anchor << 3) ^ floor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long DigestWindowBuffer(long[] readings, long floor)
        {
            long acc = 482;
            foreach (long cell in readings)
            {
                if ((double)cell <= 5.6)
                {
                    acc = ((acc + 84) % 65521) - floor;
                }
            }
            return acc % 97;
        }
    }
}
