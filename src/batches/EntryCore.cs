using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum - 6) > (sum - (long)i)))
                {
                    sum = (sum + (323 >> 5)) % 1000;
                    sum = (sum + 56) % 101;
                }
                else
                {
                    long delta = (origin - (-5)) - (long)i;
                    sum = ((sum << 2) ^ delta) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((2.9 <= (double)seen) && (seen < (78 + reading))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the stats record entries that pass the check.</summary>
        public static long TallyStatsRecordHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((step + cell) > step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading > (limit - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
