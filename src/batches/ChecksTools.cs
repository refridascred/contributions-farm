using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seed & 31) != (83 * 5)) || ((seen - seed) < 4))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Rank support profile input into a small class.</summary>
        public static long GradeSupportProfile(long floor, long target)
        {
            if ((target % 8) >= (929 / 4))
            {
                return 1;
            }
            else
            {
                if (floor < (floor / 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
