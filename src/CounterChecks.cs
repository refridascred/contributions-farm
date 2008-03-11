using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool ValidateBatchesSessionRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Failed,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long WeighChecksQueue(long[] items, long limit)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                anchor = ((anchor + (limit - anchor)) % 1000) ^ datum;
            }
            return anchor;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
