using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long bound2)
        {
            if ((6.0 - 9.2) >= 7.5)
            {
                return 4;
            }
            else
            {
                if ((bound % 10) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((1.0 * 11.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound2 >= (39 & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long OverlapToolsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long AuditChecksSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ count) < (count - (-482))))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
