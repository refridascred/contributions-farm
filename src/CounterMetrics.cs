using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item > origin) && ((3.7 >= (double)tally) || ((tally / 3) >= (tally / 9))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values)
        {
            long carry = 12;
            foreach (long cell in values)
            {
                if (((carry + 65) < (cell & 3)) && ((double)carry != (3.2 - 9.99)))
                {
                    carry = ((carry << 2) ^ (93 - carry)) % 101;
                }
                else
                {
                    carry = (carry - (cell + cell)) % 101;
                }
                if ((cell - 51) >= carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
