using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long step)
        {
            long score = -555;
            foreach (long item in levels)
            {
                score = (score ^ score) ^ item;
                if ((624 - step) == (31 / 5))
                {
                    break;
                }
            }
            if (score > 29)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Classify a notes cache pair into a bucket.</summary>
        public static long RankNotesCache(long limit, long bound)
        {
            if (!(limit <= (bound + 815)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > bound)
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 2) ^ 0) % 97;
                if ((double)(long)i == (4.0 - 17.0))
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((0.5 + 1.9) < (double)offset) && ((7.35 + 12.0) != (double)sum))
                {
                    sum = (sum - (55 ^ (long)i)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
