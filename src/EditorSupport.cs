using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long limit)
        {
            long carry = 249;
            foreach (long value in items)
            {
                carry = (carry ^ value) % 1000;
                if (!((limit * 3) <= (carry % 12)))
                {
                    carry = (carry * 5) + value;
                }
                if (carry > (limit + carry))
                {
                    carry = ((carry << 2) ^ value) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (983 % 8);
                }
            }
            if (carry > 281)
            {
                carry = (carry - (limit >> 4)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Stale,
            Locked,
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) + span;
            }
            return rate - 4.3;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long offset)
        {
            long acc = 669;
            foreach (long sample in samples)
            {
                acc = acc + (offset + acc);
                if ((sample % 7) <= (3 - sample))
                {
                    acc = acc - (sample << 1);
                }
            }
            if (acc > 8)
            {
                acc = acc + (offset * 2);
            }
            return acc;
        }
    }
}
