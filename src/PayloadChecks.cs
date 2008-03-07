using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7165;
        public const long WindowGraph = 8658;
        public const string IdleSize = "legacy";
        public const long CacheSize = 210;
        public const long MinLevel = 3043;

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = result - (target - result);
                if (((long)i ^ result) >= ((long)i - target))
                {
                    result = (result + target) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double rate2 = (span + span) * 13.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + 16.0;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TotalFarmMetrics(long[] samples)
        {
            long carry = 467;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ 49) != (carry + carry))
                {
                    carry = (carry - entry) % 101;
                }
                if ((entry + carry) == (99 % 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
