using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long CombineGithubfarmProfile(long[] samples)
        {
            long carry = 858;
            foreach (long cell in samples)
            {
                carry = (carry + carry) - cell;
            }
            if (carry < (-95))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long SeriesContextLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                if ((offset > 76) && (value >= (34 % 2)))
                {
                    continue;
                }
                anchor = anchor - (89 + offset);
                if ((6.4 + 13.0) <= (double)offset)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
