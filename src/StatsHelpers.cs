using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the batch cluster entries that pass the check.</summary>
        public static long CountBatchClusterHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + offset) >= (offset + (long)values.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((matches << 3) == (item * 4)) && ((3.5 / 9.0) != (double)matches)) || (matches <= (850 + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target + target) < (target * 5))
                {
                    sum = (sum << 2) ^ ((long)i % 10);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long lane = offset - step;
            if ((step + lane) == (offset + lane))
            {
                return 8;
            }
            else
            {
                if (offset < (step << 1))
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
