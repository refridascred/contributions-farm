using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ ((long)i >> 3);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((4.0 - 1.43) > (double)prev)
            {
                return 4;
            }
            else
            {
                if (prev < (prev + offset))
                {
                    return 7;
                }
                else
                {
                    if ((prev >> 5) == (offset - 59))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count stats commits pairs that satisfy a relation.</summary>
        public static long OverlapStatsCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
