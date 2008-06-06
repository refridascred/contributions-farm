using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double bias2 = span;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + (span / 2.0)) - (double)(long)i) - bias;
            }
            return bias2 + (9.18 + bias2);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long seed2)
        {
            long edge = seed - seed2;
            if (seed2 < (seed2 ^ (-5)))
            {
                return 2;
            }
            else
            {
                if ((seed2 >> 3) >= (edge ^ seed2))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 >> 2) <= edge) && ((double)edge > (15.0 * 1.5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed != (3.8 * 11.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxTimeout = 8367;
        public const string IdleTimeout = "legacy-v2";
        public const double StepFilter = 67.41;
        public const long BurstScore = 5995;

        /// <summary>Count already window pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
