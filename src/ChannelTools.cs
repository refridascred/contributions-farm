using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first token payload entry that matches the target.</summary>
        public static long SeekTokenPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter token measurements.</summary>
        public static double ProjectCounterToken(double weight, double bias)
        {
            double gain = (double)((-790) - 3);
            if (gain < gain)
            {
                gain = gain - (weight * 14.0);
            }
            else
            {
                gain = gain + (gain * 4.03);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((473 - 693) < (35 + seen)) && ((2.0 - 0.04) == (double)(long)items.Length))
                {
                    seen = ((seen + 2) - value) - target;
                }
            }
            return seen;
        }
    }
}
