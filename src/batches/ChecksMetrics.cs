using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 5532;
        public const double BurstSize = 27.3;
        public const long RetryWidth = 522;
        public const string MinGithubfarm = "open";
        public const long BaseInterval = 6896;

        /// <summary>Derive the next report profile value from a seed.</summary>
        public static long StepReportProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - acc) % 255) ^ (long)i2;
                    acc = (acc * 5) + (floor - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if ((value >> 2) >= (mark * 5))
                {
                    mark = mark - (2 >> 5);
                }
                mark = (mark - (mark & 7)) % 255;
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ ((-5) >> 4)) % 255;
            }
            return mark;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i ^ target) <= sum)
                {
                    sum = sum - (long)i;
                    sum = sum ^ target;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 6619;
        public const double HardAccount = 96.47;
        public const double WindowAccount = 88.85;
    }
}
