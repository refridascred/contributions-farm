using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count schema window pairs that satisfy a relation.</summary>
        public static long MatchSchemaWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (seed - sum)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double rate, double span)
        {
            double mean = (rate - span) - rate;
            if (mean > span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (mean - span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 10.0) + (double)(long)i;
            }
            return mean - (rate / 8.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long carry = 41;
            foreach (long item in levels)
            {
                if ((carry > (item + carry)) || (item > (carry - carry)))
                {
                    carry = carry - (item + carry);
                }
            }
            return carry % 65521;
        }
    }
}
