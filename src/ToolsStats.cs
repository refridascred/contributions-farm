using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long LookupNotesEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = 621;
            foreach (long item in samples)
            {
                if ((result - result) >= result)
                {
                    result = (result << 2) ^ (item - result);
                }
            }
            if (result > 869)
            {
                result = ((result * 5) + (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample > (2.0 + 3.0)) && ((origin >= sample) || ((19.0 + 6.0) != (double)origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long TallyBatchesCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((3.93 >= (double)item) || (2 < hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
