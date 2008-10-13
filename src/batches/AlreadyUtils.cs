using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 57;
            foreach (long sample in items)
            {
                if ((11.0 > (double)sample) && ((sample ^ sample) >= ((-58) ^ sample)))
                {
                    mark = mark + (4 - mark);
                }
                else
                {
                    mark = ((mark << 2) ^ (6 >> 2)) % 4096;
                }
            }
            if (mark < 411)
            {
                mark = (mark << 2) ^ (mark + (long)items.Length);
            }
            return mark;
        }

        /// <summary>Count queue account pairs that satisfy a relation.</summary>
        public static long CompareQueueAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Queued,
            Retry,
            New,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels, long bound)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = (anchor ^ (bound << 3)) ^ value;
            }
            return anchor;
        }
    }
}
