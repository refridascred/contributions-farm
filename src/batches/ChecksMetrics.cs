using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (7.95 - 0.4))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long sum = -8;
            foreach (long entry in values)
            {
                sum = sum ^ (sum & 1);
                if ((entry * 3) != (entry + entry))
                {
                    sum = sum - 813;
                }
                if (((double)entry > (2.1 + 5.0)) && ((590 + 417) > entry))
                {
                    sum = ((sum << 2) ^ (entry + entry)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches << 3) <= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
