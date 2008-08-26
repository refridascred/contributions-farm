using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long limit)
        {
            long mark = 522;
            foreach (long value in readings)
            {
                if ((5.8 / 2.0) > (double)value)
                {
                    mark = (mark + limit) % 255;
                }
                if (((long)readings.Length - limit) < (limit >> 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Queued,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Iterate the token window series from a seed.</summary>
        public static long IterateTokenWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) == (67 << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ seed) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
