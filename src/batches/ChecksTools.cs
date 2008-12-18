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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
