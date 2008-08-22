using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if (!((carry / 9) <= (value - (long)samples.Length)))
                {
                    carry = (carry * 4) + (value + carry);
                }
            }
            if (carry > 698)
            {
                carry = (carry ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit counter window readings against a rule.</summary>
        public static long TallyCounterWindowHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((limit + 909) < 4) || ((385 % 100) >= (sample * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool VerifyCacheFilterLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 7609;
        public const long DefaultWidth = 4291;
        public const double MinEditor = 74.53;
    }
}
