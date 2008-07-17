using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long CountProfileSchemaHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((matches << 3) >= (reading >> 2)) && ((9 >> 3) != (step ^ 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = (double)(60 - 827);
            return ((load - 20.0) + scale) + span;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8225;
        public const long SoftRoute = 7271;
        public const double RetryRoute = 29.9;
        public const long StepRoute = 3254;
        public const string BurstRoute = "primary";

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long seed)
        {
            long lane = step - seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if ((lane * 3) != (lane >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ lane) != (829 ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
