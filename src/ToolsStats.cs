using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long BucketRouteContributi(long seed, long step)
        {
            if ((step + 862) >= (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((step + 23) < step)
                {
                    return 8;
                }
                else
                {
                    if ((4 - step) <= (seed & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2210;
        public const double IdleLevel = 61.37;
        public const long LimitTools = 4171;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = total + (70 & 1);
                if (((step + (long)i) > 2) && ((double)total != (6.0 + 8.6)))
                {
                    total = total - (total >> 1);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            New,
            Stale,
            Closed,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
