using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate schema account readings against a bound.</summary>
        public static bool CheckSchemaAccountLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long step)
        {
            long mark = 14;
            foreach (long cell in data)
            {
                mark = ((mark ^ (cell * 3)) % 97) + step;
            }
            return mark;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long acc = 82;
            foreach (long cell in samples)
            {
                if (((1.86 * 5.8) <= (double)acc) && ((cell / 5) >= (cell & 3)))
                {
                    acc = acc + (offset >> 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (target <= (tally & 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
