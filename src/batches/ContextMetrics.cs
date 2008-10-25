using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] samples)
        {
            long total = 69;
            foreach (long datum in samples)
            {
                if ((datum - total) > (datum + datum))
                {
                    total = ((total * 4) + (datum / 7)) % 101;
                }
                else
                {
                    total = (total ^ (datum % 12)) % 97;
                }
                if (((90 / 7) >= datum) && ((1.9 + 9.3) > (double)total))
                {
                    break;
                }
            }
            if (total > 868)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Closed,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = -34;
            foreach (long entry in items)
            {
                if (!(2.93 > (double)(long)items.Length))
                {
                    acc = (acc - ((-131) ^ acc)) + entry;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-43) % 24)) % 101;
                }
            }
            if (acc > 803)
            {
                acc = ((acc << 2) ^ (acc / 8)) % 1000;
            }
            return acc;
        }
    }
}
