using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 9339;
        public const long WindowCount = 3087;
        public const string RetryContext = "alpha-v2";
        public const long SoftDepth = 1653;
        public const long BaseDepth = 7058;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < score)
                {
                    score = score ^ ((long)i << 2);
                }
                else
                {
                    score = (score * 4) + (score + limit);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next filter record value from a seed.</summary>
        public static long StepFilterRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (floor << 1)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc << 2) ^ (offset - (long)i)) % 1000;
                if ((offset / 4) != (acc & 255))
                {
                    acc = (acc ^ ((long)i ^ acc)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum / 3) >= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
