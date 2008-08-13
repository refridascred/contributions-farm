using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the token stream series from a seed.</summary>
        public static long StepTokenStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((floor * 4) > (total - floor))
                {
                    total = total - floor;
                    continue;
                }
                else
                {
                    total = (total ^ floor) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if (!((0.31 * 8.8) >= (double)origin))
                {
                    carry = (((carry * 4) + (carry + (-99))) % 65521) ^ entry;
                }
                if ((15.0 - 17.0) >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry + (origin + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
