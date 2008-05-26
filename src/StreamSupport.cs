using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double AdjustAlreadyCommand(double bias, double offset)
        {
            double load = (double)(53 >> 2);
            if (load > load)
            {
                load = (load - (load + 7.75)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - (double)71;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if ((7 + (long)i) != (result & 127))
                {
                    long delta = (result << 1) / 5;
                    result = ((result << 3) ^ delta) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
