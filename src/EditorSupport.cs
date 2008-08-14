using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (((3.0 / 4.0) <= (double)cur) || ((seed >> 1) >= (seed << 2)))
            {
                return 1;
            }
            else
            {
                if (((742 * 3) > (seed2 << 1)) || ((double)cur == (3.36 - 3.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - (result + (long)i)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + weight) + (double)(long)i) + offset;
            }
            return ratio - (weight / 9.0);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema token readings against a rule.</summary>
        public static long TallySchemaTokenMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + limit) < (7 ^ limit))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a channel support sample.</summary>
        public static long FindChannelSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
