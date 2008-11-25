using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels, long target)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry > (90 + (-5))) && ((9.25 / 4.0) == (double)acc))
                {
                    acc = ((acc + (acc + 11)) % 65521) - target;
                }
                else
                {
                    acc = acc - (3 + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
