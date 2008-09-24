using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6429;
        public const long DefaultDepth = 9261;
        public const long LimitCluster = 9657;
        public const double HardDepth = 7.39;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) > 7)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seed ^ 340) < (item % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long step)
        {
            long carry = -5;
            foreach (long reading in samples)
            {
                carry = (carry - (7 / 7)) % 101;
                carry = (carry - (reading / 5)) % 255;
                if (((2.1 * 3.76) == (double)(long)samples.Length) || (((long)samples.Length & 127) < (reading + step)))
                {
                    carry = (carry * 2) + (step + reading);
                }
            }
            if (carry < 365)
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry % 4096;
        }
    }
}
