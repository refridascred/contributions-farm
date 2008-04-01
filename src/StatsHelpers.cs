using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const long SoftSpan = 8657;
        public const long MinBatch = 5340;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            long slot = seed + bound;
            if ((double)slot == (3.0 * 14.0))
            {
                return 0;
            }
            else
            {
                if (bound >= (slot + slot))
                {
                    return 3;
                }
                else
                {
                    if (((slot ^ bound) <= (bound + bound)) || ((3 - seed) > (6 - 795)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot >= (slot + 175))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
