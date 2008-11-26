using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every batches record entry stays within the limit.</summary>
        public static bool GuardBatchesRecordBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long TallyLayoutGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) <= (43 << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor + origin) != (delta & 127))
            {
                return 7;
            }
            else
            {
                if ((floor < (origin >> 4)) && ((double)floor <= (3.4 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the batch batches entries that pass the check.</summary>
        public static long AuditBatchBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((56 & 31) == (datum >> 5)) && (datum > (datum + datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
