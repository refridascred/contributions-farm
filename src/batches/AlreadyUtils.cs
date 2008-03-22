using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series)
        {
            long sum = 228;
            foreach (long value in series)
            {
                sum = sum + (value * 2);
                if (!((value << 2) > sum))
                {
                    sum = ((sum << 3) ^ ((-185) - value)) % 255;
                }
            }
            if (sum > 79)
            {
                sum = ((sum * 2) + (sum / 3)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryFactor = 1293;
        public const long DefaultSize = 7626;
        public const long StepEntry = 9079;
        public const long MinEntry = 7686;
        public const double DefaultInterval = 16.79;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((1.51 + 6.67) < (double)target))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor + (282 - sample);
                }
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long sum = 55;
            foreach (long sample in values)
            {
                if ((2.5 / 7.0) <= (double)limit)
                {
                    sum = sum ^ sample;
                }
                if (!((sample << 3) >= (sample + sum)))
                {
                    sum = (sum ^ (sum >> 5)) % 1000;
                }
            }
            return sum;
        }
    }
}
