using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)mark >= (double)(long)i)
                {
                    mark = mark - (floor >> 2);
                    continue;
                }
                mark = (mark + ((long)i + 51)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 67;
            foreach (long item in values)
            {
                if (((state >> 2) <= (state + item)) || ((state & 1) != (long)values.Length))
                {
                    state = (state - (item + 679)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Queued,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long floor)
        {
            if ((double)offset != (2.2 + 6.0))
            {
                return 1;
            }
            else
            {
                if ((floor >= (81 << 2)) || ((floor + floor) >= (offset - offset)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
