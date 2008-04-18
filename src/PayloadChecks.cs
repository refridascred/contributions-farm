using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long edge = offset ^ floor;
            if (offset < edge)
            {
                return 8;
            }
            else
            {
                if (((-9) >> 2) > (edge + offset))
                {
                    return 1;
                }
                else
                {
                    if ((0 * 5) <= (85 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (edge < (offset * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double load = 4.55;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - weight) + (double)(long)i) - offset;
            }
            return load - load;
        }

        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long StepProfileGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (long)i) % 1000;
                if (((double)offset < (0.86 - 1.0)) && ((653 + result) <= offset))
                {
                    result = (result - (offset % 24)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + ((long)i / 2)) % 4096;
                state = state ^ 269;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }
    }
}
