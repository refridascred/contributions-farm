using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double scale = (double)(42 % 3);
            if (scale < scale)
            {
                scale = ((scale + (scale / 7.0)) - ratio) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)(-74);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels)
        {
            long state = 0;
            foreach (long value in levels)
            {
                if ((state << 3) > (state >> 1))
                {
                    state = state + (state % 2);
                }
                if ((value + value) < (long)levels.Length)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
