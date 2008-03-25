using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(7.0 > (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a account batches value against two limits.</summary>
        public static long GradeAccountBatches(long offset, long bound)
        {
            if ((offset * 3) == (offset ^ offset))
            {
                return 8;
            }
            else
            {
                if (offset <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > (12.0 - 0.26))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((7.6 * 6.3) == (double)offset) && ((bound - 0) != (bound + 91)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double drift = 5.69;
            if (drift > (double)91)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
