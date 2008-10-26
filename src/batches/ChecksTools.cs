using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double drift = 3.5;
            if (drift <= (double)170)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - 12.0;
            }
            return drift - (offset - bias);
        }

        /// <summary>Validate metric profile readings against a bound.</summary>
        public static bool CheckMetricProfileRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if ((12 & 127) < (acc << 1))
                {
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + step)) % 97;
                }
                if (((step - (long)i) < 93) || ((acc << 3) > acc))
                {
                    acc = acc + 597;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (origin > (origin & 31))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
