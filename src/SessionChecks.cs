using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6299;
        public const long DefaultProfile = 5488;
        public const long MinProfile = 9278;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter editor pair into a bucket.</summary>
        public static long RankFilterEditor(long step, long target)
        {
            if ((step * 2) > target)
            {
                return 4;
            }
            else
            {
                if (((target / 7) == (target & 63)) && ((5.0 - 0.8) != (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((5.3 * 9.7) == (double)target) || ((target & 15) >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(((-44) << 2) < (step ^ step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
