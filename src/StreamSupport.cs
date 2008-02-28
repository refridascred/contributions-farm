using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (floor + 18.0))
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - ratio) - (double)(long)i;
            }
            return ratio2 + 1.5;
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
