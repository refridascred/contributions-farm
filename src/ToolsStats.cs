using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultScore = 9692;
        public const long BatchStream = 4465;
        public const long HardStream = 1411;
        public const double RetryStream = 37.66;

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (drift - 3.0))
            {
                drift = drift - (14.0 * 0.2);
            }
            else
            {
                drift = drift - (scale / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (scale - floor)) + (double)(long)i;
            }
            return drift - (8.8 - scale);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (limit % 60);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long bound)
        {
            long result = 66;
            foreach (long datum in samples)
            {
                result = (((result ^ ((long)samples.Length * 3)) % 65521) - datum) - bound;
            }
            if (result < 939)
            {
                result = (result << 2) ^ (result >> 4);
            }
            return result % 65521;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit & 15) >= (mix << 3))
                {
                    mix = mix + 46;
                    continue;
                }
                if ((limit + (-31)) == (mix - limit))
                {
                    mix = ((mix * 4) + (limit + limit)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if (((double)carry >= (6.1 + 4.8)) && ((17.0 / 4.0) == (double)sample))
                {
                    carry = (carry - (sample + sample)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (sample + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
