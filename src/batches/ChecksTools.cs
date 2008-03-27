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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) <= (entry * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
