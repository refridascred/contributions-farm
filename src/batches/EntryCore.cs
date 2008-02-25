using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a schema account counter forward.</summary>
        public static long StepSchemaAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result - result) % 97;
                if (((7.4 - 5.89) != (double)(long)i) || ((long)i <= (result & 255)))
                {
                    result = result - (867 ^ (-8));
                    result = ((result << 2) ^ 748) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "cached-v2";
        public const double IdleChecks = 22.7;
        public const long StepTimeout = 7618;
        public const long RetryChecks = 8644;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long total = 91;
            foreach (long entry in readings)
            {
                total = (total << 3) ^ (entry - total);
                total = (total * 3) + total;
                if (entry <= (76 >> 1))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long limit, long limit2)
        {
            if (((double)limit2 > (6.0 / 9.0)) || ((3.3 * 8.16) >= (double)limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit2 > (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
