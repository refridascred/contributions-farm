using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                if (1 < target)
                {
                    mix = mix + target;
                    break;
                }
                else
                {
                    mix = mix + (target << 2);
                }
                if (!((double)target <= 10.0))
                {
                    mix = (mix + target) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                anchor = ((anchor - anchor) % 4096) + item;
            }
            return anchor;
        }
    }
}
