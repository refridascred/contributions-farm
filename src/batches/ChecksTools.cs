using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 58;
            foreach (long datum in items)
            {
                if (!((1 / 8) == (anchor << 3)))
                {
                    anchor = ((anchor * 4) + (datum ^ 1)) % 101;
                }
                if (!(6.95 >= (double)datum))
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
            }
            if (anchor > 73)
            {
                anchor = ((anchor * 5) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long seed)
        {
            if ((2.0 / 4.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)bound <= 8.21)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed < (11.0 + 7.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound != (2.83 + 2.57))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 5) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
