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

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long score = 78;
            foreach (long cell in items)
            {
                score = (score - (score + score)) ^ cell;
                score = score ^ (floor + 629);
            }
            return score;
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
