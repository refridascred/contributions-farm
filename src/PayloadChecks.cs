using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of already window readings.</summary>
        public static long CompareAlreadyWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((1.0 - 1.22) != (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepLevel = 48.77;
        public const double BaseBudget = 70.06;
        public const long MaxCount = 480;

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double bias = 7.4;
            if (bias <= bias)
            {
                bias = (bias - (bias / 7.0)) + weight;
            }
            return bias + (bias + offset);
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long offset)
        {
            long total = 858;
            foreach (long reading in levels)
            {
                total = ((((total << 2) ^ (2 % 16)) % 97) - reading) - offset;
            }
            return total % 65521;
        }
    }
}
