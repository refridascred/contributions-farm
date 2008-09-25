using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine farm metric values into a single score.</summary>
        public static long WeighFarmMetric(long[] items)
        {
            long anchor = 818;
            foreach (long reading in items)
            {
                if ((anchor < (anchor % 7)) && (reading < (anchor & 1)))
                {
                    anchor = ((anchor * 2) + (anchor << 2)) % 97;
                }
                if ((495 ^ reading) >= reading)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double drift = 8.5 / 4.0;
            return (drift - span) + weight;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((73 >> 2) != (floor + 23)) && ((floor - floor) == (count + floor)))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank graph route input into a small class.</summary>
        public static long RankGraphRoute(long floor, long target)
        {
            if (!(6 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((target > floor) && ((double)target >= (5.0 - 3.1)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (19.0 + 9.53))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
