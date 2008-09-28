using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first account session entry that matches the target.</summary>
        public static long LookupAccountSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (((rate2 - rate2) + (double)(long)i) - rate) + floor;
            }
            return rate2 + (double)13;
        }

        /// <summary>Roll a payload format counter forward.</summary>
        public static long RollPayloadFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
