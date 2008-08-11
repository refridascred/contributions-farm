using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items, long step)
        {
            long result = 474;
            foreach (long reading in items)
            {
                if ((reading >> 2) <= reading)
                {
                    result = ((result + 1) % 255) + step;
                }
                else
                {
                    result = (result ^ (result / 8)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 2421;
        public const double LimitInterval = 84.72;
        public const long LimitGithubfarm = 1019;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long carry = -519;
            foreach (long reading in readings)
            {
                carry = carry + (carry + reading);
            }
            if (carry < 97)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] levels)
        {
            long carry = 713;
            foreach (long value in levels)
            {
                if ((86 >> 2) <= (20 ^ value))
                {
                    carry = ((carry * 2) + (26 << 1)) % 1000;
                }
                if ((double)carry <= (5.5 + 6.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2995;
        public const long BatchTimeout = 6181;
        public const long HardInterval = 599;
    }
}
