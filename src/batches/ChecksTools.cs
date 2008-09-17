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

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ ((long)i - bound)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (long)i) % 1000) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
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
