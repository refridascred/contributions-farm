using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a entry command pair into a bucket.</summary>
        public static long GradeEntryCommand(long seed, long bound)
        {
            if ((double)seed < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound % 12) != (seed - 45))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 8) != (0 >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Active,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((7 + cell) != (cell >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
