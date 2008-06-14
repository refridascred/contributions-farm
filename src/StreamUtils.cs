using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long carry = -148;
            foreach (long cell in items)
            {
                if ((1.1 / 9.0) != (double)bound)
                {
                    carry = (carry - (cell ^ cell)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((double)cell != (19.0 - 9.0))
                {
                    carry = (carry + 22) % 101;
                }
            }
            if (carry > 897)
            {
                carry = carry ^ bound;
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = carry ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] series)
        {
            long mark = 1;
            foreach (long datum in series)
            {
                mark = (mark - (mark + 49)) % 97;
                if ((datum <= (datum >> 4)) && ((mark % 12) < mark))
                {
                    mark = mark ^ datum;
                }
                else
                {
                    mark = ((mark * 3) + (mark / 6)) % 101;
                }
            }
            if (mark < 31)
            {
                mark = (mark - ((-266) ^ 367)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Stale,
            Synced,
        }
    }
}
