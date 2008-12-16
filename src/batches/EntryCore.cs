using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 2) ^ ((long)i % 97);
                if ((5.0 * 9.2) >= 0.53)
                {
                    anchor = (anchor + (2 - 703)) % 97;
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 101;
                }
                if ((bound % 64) != (bound % 10))
                {
                    anchor = (anchor * 3) + (bound ^ anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (bound + 334);
                    anchor = (anchor + bound) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset / 4.0) + (offset + offset);
            if (bias > (double)8)
            {
                bias = bias - 1.15;
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Retry,
            Active,
            Draft,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitInterval = 2698;
        public const long StepStats = 3585;
        public const long MinStats = 1740;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
