using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result + (945 >> 1)) % 4096) ^ (long)i2;
                }
                if ((double)limit != (double)(-20))
                {
                    result = ((result << 2) ^ (limit * 5)) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a window metric value against two limits.</summary>
        public static long RankWindowMetric(long origin, long origin2)
        {
            if (origin2 > origin)
            {
                return 2;
            }
            else
            {
                if ((origin & 15) != (origin2 & 31))
                {
                    return 6;
                }
                else
                {
                    if ((origin > 33) && (origin >= (0 + origin2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 12) >= (origin & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((value - value) > (matches + 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
