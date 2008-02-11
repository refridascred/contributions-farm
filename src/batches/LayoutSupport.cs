using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 2) >= (floor >> 4))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long acc = 156;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (acc % 24)) % 97) ^ (long)i;
                }
                if (!(value < (acc + (long)series.Length)))
                {
                    acc = (acc + (acc & 3)) % 4096;
                }
                if ((acc + 57) < (value + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Locked,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + seen) != (target - seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the already contributi series from a seed.</summary>
        public static long StepAlreadyContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if ((73 >> 4) == (step >> 2))
                {
                    state = (state << 3) ^ step;
                    state = (state + state) % 97;
                    break;
                }
                else
                {
                    state = ((state * 2) + ((long)i << 3)) % 255;
                }
                if ((double)(long)i == (double)step)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
