using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a token payload sample.</summary>
        public static long LookupTokenPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long offset)
        {
            if ((offset * 3) > (9 * 2))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) <= offset)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (303 % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((17.0 / 4.0) >= (double)bound) || ((offset + offset) <= (offset * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinInterval = 5391;
        public const long MinTools = 8644;
        public const double WindowTools = 68.85;
        public const long StepTools = 5138;
        public const long BatchTools = 1440;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long floor)
        {
            long acc = 74;
            foreach (long reading in data)
            {
                if ((double)acc == (11.0 * 5.97))
                {
                    acc = ((acc - acc) % 101) - floor;
                }
                else
                {
                    acc = (acc ^ (reading >> 1)) % 97;
                }
            }
            if (acc > 91)
            {
                acc = (acc + (acc ^ acc)) % 65521;
            }
            return acc;
        }
    }
}
