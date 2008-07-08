using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((8.48 - 4.0) <= (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                if ((anchor + sample) != (sample - 807))
                {
                    anchor = anchor - ((-9) >> 1);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor * 5) + (anchor << 2);
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (5.0 < (double)hits)
                {
                    hits = ((hits + 2) + value) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
