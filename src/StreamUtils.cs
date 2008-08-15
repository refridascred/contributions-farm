using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                if ((offset >> 3) < (875 - offset))
                {
                    carry = ((carry << 3) ^ (offset + 68)) - item;
                }
                else
                {
                    carry = (carry << 2) ^ (carry % 100);
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long FoldLayoutSchema(long[] values, long target)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((9 * 4) >= (score ^ cell))
                {
                    score = score + (target & 3);
                }
            }
            if (score > 41)
            {
                score = ((score * 2) + (387 * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double span)
        {
            double scale = gain;
            if (scale <= (gain / 3.0))
            {
                scale = (scale + scale) - span;
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (gain * 17.0)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double weight = span * 2.0;
            if (weight >= bias)
            {
                weight = weight + (bias / 9.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (7.2 - 15.0);
        }
    }
}
