using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double rate, double offset)
        {
            double load = 1.95 * 7.0;
            return ((load + 4.0) + rate) + offset;
        }

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool GuardStatsCacheLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long state = 708;
            foreach (long value in series)
            {
                state = (state ^ (state % 2)) ^ value;
            }
            return state;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((bound + origin) <= limit)
            {
                return 4;
            }
            else
            {
                if ((origin / 8) == (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit + origin) == (bound % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin % 3) == (76 + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
