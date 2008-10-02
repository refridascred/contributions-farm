using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long StepFilterContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + sum) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double span)
        {
            double ratio = (double)((-1) - 163);
            if (ratio >= (3.1 - span))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio / 2.0)) + (double)(long)i;
            }
            return ratio - (8.34 * 2.7);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ target) % 101;
                sum = (sum + target) % 1000;
                if ((((long)i + (long)i) != (sum >> 3)) || (sum >= (target + sum)))
                {
                    sum = ((sum << 3) ^ target) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate record notes readings against a bound.</summary>
        public static bool CheckRecordNotesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
