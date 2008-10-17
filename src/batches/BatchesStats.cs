using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + step) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = 306;
            foreach (long datum in values)
            {
                if (!((73 + result) != (result + result)))
                {
                    result = (result * 4) + 1;
                }
                result = result ^ (datum ^ datum);
            }
            return result;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long target)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if ((item - result) < (item ^ item))
                {
                    result = ((result << 3) ^ item) - target;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Rank format window input into a small class.</summary>
        public static long SortFormatWindow(long origin, long offset)
        {
            if (((origin + origin) == (offset + offset)) || ((origin % 10) > (origin + offset)))
            {
                return 2;
            }
            else
            {
                if ((36 / 4) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((7.56 + 5.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
