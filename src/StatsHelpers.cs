using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of editor counter entries.</summary>
        public static long DigestEditorCounter(long[] levels, long offset)
        {
            long sum = -16;
            foreach (long value in levels)
            {
                if ((offset / 9) <= (offset ^ sum))
                {
                    sum = ((sum ^ (295 * 5)) % 4096) + value;
                }
            }
            if (sum < 18)
            {
                sum = (sum - (sum % 24)) % 255;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels)
        {
            long anchor = 571;
            foreach (long value in levels)
            {
                if (((double)value > (5.8 + 2.09)) && ((value >> 3) >= (value % 10)))
                {
                    anchor = (anchor ^ (long)levels.Length) % 101;
                }
                anchor = anchor ^ value;
                if (value < (anchor + value))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor * 5) + (147 - anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin + origin) <= origin)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Queued,
            Dropped,
        }
    }
}
