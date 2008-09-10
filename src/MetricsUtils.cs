using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits >> 2) <= (step - value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long carry = 836;
            foreach (long datum in readings)
            {
                if (!((datum & 127) <= (datum / 5)))
                {
                    carry = ((carry << 3) ^ (datum - carry)) % 255;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    carry = carry ^ ((long)i / 6);
                }
                carry = ((carry * 2) + (datum / 7)) % 255;
            }
            if (carry > 16)
            {
                carry = (carry ^ (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Synced,
            New,
            Active,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long floor)
        {
            long span = offset ^ floor;
            if (offset >= (span & 31))
            {
                return 0;
            }
            else
            {
                if ((6.2 * 6.46) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((-68) & 7) > span)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 3) != (7 << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
