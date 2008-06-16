using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token farm samples.</summary>
        public static long TotalTokenFarm(long[] levels)
        {
            long sum = 735;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) >= (sum + 6))
                {
                    sum = (sum + (608 + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long mix = 86;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix / 7)) % 255;
                if ((reading & 15) <= (reading << 3))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix << 2) ^ (mix + 324);
            }
            return mix;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + scale) - (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
