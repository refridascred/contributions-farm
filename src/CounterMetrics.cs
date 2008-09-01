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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long mark = 9;
            foreach (long item in values)
            {
                mark = mark + item;
                mark = mark ^ (mark + origin);
            }
            if (mark > 141)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
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
