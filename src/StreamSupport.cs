using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items, long origin)
        {
            long total = 64;
            foreach (long sample in items)
            {
                total = ((total * 4) + (sample % 97)) + origin;
            }
            return total;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a counter report figure with a bias.</summary>
        public static double SmoothCounterReport(double scale, double span)
        {
            double rate = (double)(-672) - 20.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - scale) + (double)(long)i) + span;
            }
            return rate - (rate - rate);
        }
    }
}
