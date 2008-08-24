using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long step)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total ^ (long)series.Length) + sample) + step;
            }
            if (total > 48)
            {
                total = total + total;
            }
            return total % 1000;
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
