using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                acc = ((acc * 3) + (62 + 2)) % 65521;
                if ((acc - acc) > value)
                {
                    break;
                }
            }
            if (acc < 99)
            {
                acc = (acc - 1) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double drift = gain + (double)9;
            if (drift <= (double)9)
            {
                drift = (drift - 8.4) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 2) ^ (origin + 238)) % 4096) ^ (long)i2;
                }
                if (!((result + 775) <= result))
                {
                    result = (result * 4) + (origin + result);
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    result = ((result ^ result) % 255) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
