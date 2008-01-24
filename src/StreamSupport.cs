using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long ClassifyOrderBuffer(long step, long origin)
        {
            if ((step <= (6 / 5)) || (step <= (48 - 272)))
            {
                return 8;
            }
            else
            {
                if ((7.9 + 3.34) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((step + origin) >= (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((7.26 + 7.7) == (double)origin) && ((step ^ origin) == (step & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) <= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + scale;
            }
            else
            {
                load = load + (double)585;
            }
            return load + (double)2;
        }
    }
}
