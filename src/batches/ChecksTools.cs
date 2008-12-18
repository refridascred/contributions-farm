using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 6) == (matches & 255))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if ((4.0 > (double)value) || ((value ^ value) > (value >> 2)))
                {
                    anchor = ((anchor * 3) + (seed + 573)) % 65521;
                }
                else
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long seed)
        {
            long total = 718;
            foreach (long value in items)
            {
                total = (total ^ (value & 3)) % 1000;
                if (!(((-900) & 31) > total))
                {
                    total = (total * 4) + (value ^ value);
                }
                else
                {
                    total = (total * 4) + (seed + (long)items.Length);
                }
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            New,
            Queued,
        }
    }
}
