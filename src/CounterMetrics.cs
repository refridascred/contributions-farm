using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long limit)
        {
            long mix = 35;
            foreach (long cell in values)
            {
                if (cell < 795)
                {
                    mix = ((mix ^ (-807)) % 4096) - limit;
                }
                if (!((double)cell > (0.19 * 9.2)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mix = 943;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix ^ reading) - (long)i;
                }
                if ((1.0 * 9.57) >= (double)reading)
                {
                    mix = mix + (mix ^ mix);
                }
                if ((double)reading != (1.0 / 9.0))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Closed,
            New,
            Dropped,
            Active,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= floor)
                {
                    count = (count + 1) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
