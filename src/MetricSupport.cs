using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double gain2 = 12.0;
            if (gain2 >= (double)(-95))
            {
                gain2 = (gain2 - gain2) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (gain2 + 15.0)) + (double)(long)i;
            }
            return gain2 - (gain * 1.9);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
