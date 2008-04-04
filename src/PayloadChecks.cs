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

        /// <summary>Fold a list of checks schema readings.</summary>
        public static long TallyChecksSchema(long[] series)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                if ((200 - mark) >= (mark & 1))
                {
                    mark = ((mark ^ (5 & 1)) % 101) + cell;
                }
            }
            if (mark < 68)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 4096;
        }
    }
}
