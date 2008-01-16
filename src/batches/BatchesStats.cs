using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two buffer stream measurements.</summary>
        public static double AdjustBufferStream(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (double)66)
            {
                weight = weight + ratio;
            }
            return weight - (double)56;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long origin, long target)
        {
            if ((0.3 * 12.0) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((origin < (691 - target)) || ((double)target == (2.24 * 1.05)))
                {
                    return 3;
                }
                else
                {
                    if ((84 << 2) == (origin ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long origin)
        {
            long mix = -30;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ (origin & 63)) % 97) + value;
                if (((8.0 / 9.0) == (double)mix) || ((origin & 255) == (origin & 7)))
                {
                    break;
                }
            }
            if (mix > (-60))
            {
                mix = (mix ^ (-4)) % 255;
            }
            return mix % 65521;
        }
    }
}
