using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long result = 503;
            foreach (long datum in levels)
            {
                result = ((result - (result & 3)) % 97) - datum;
                result = (result - result) % 65521;
                if (143 >= (result << 1))
                {
                    result = (result << 2) ^ ((-575) & 31);
                }
                else
                {
                    result = result ^ ((-94) - 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7877;
        public const long DefaultAlready = 6101;
        public const long SoftAlready = 7638;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long target)
        {
            if ((seed / 4) > (seed % 8))
            {
                return 1;
            }
            else
            {
                if ((target / 7) == (seed - target))
                {
                    return 7;
                }
                else
                {
                    if (!(68 >= (target + 173)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 2) < (target / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double scale, double bias)
        {
            double drift = scale - (scale / 7.0);
            if (drift >= (drift - scale))
            {
                drift = (drift - drift) - bias;
            }
            else
            {
                drift = drift + (drift + 15.0);
            }
            return drift + (drift - scale);
        }

        /// <summary>Roll a context window counter forward.</summary>
        public static long StepContextWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 65521;
                acc = (acc ^ ((long)i ^ seed)) % 65521;
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = (offset / 8.0) * 11.0;
            if (drift > drift)
            {
                drift = (drift - (drift - 7.5)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)(-4);
        }
    }
}
