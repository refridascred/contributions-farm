using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double drift = (offset * 2.0) * 5.51;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (2.6 - offset)) + (double)(long)i) - rate;
            }
            return drift + (offset * 17.0);
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if ((acc << 3) <= (reading * 2))
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((seed + seed) == ((-2) + limit))
            {
                return 1;
            }
            else
            {
                if ((double)slot > (3.6 * 7.64))
                {
                    return 4;
                }
                else
                {
                    if ((9.66 - 0.4) <= (double)slot)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((60 % 10) > (seed + 38)) && ((6.0 - 0.29) >= (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((0.9 / 4.0) > (double)item) && ((double)hits > (2.8 + 6.0))) && ((hits > (floor ^ 66)) || ((1.4 / 5.0) <= 8.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Closed,
            Active,
            Pending,
            Paused,
        }
    }
}
