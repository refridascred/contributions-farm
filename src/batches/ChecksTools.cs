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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Draft,
            Dropped,
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9407;
        public const long LimitFactor = 2894;
        public const long DefaultBatch = 1963;
        public const long StepBatch = 5834;
    }
}
