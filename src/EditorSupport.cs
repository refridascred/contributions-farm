using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long DeriveFormatStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (mix ^ (long)i)) % 101;
                if ((target > (mix & 127)) && ((mix * 2) < 2))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of route schema readings.</summary>
        public static long CombineRouteSchema(long[] readings)
        {
            long acc = 31;
            foreach (long datum in readings)
            {
                acc = ((acc * 4) + (datum >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long bound)
        {
            long offset = origin - bound;
            if ((7.7 / 3.0) == (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)offset < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ bound) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
