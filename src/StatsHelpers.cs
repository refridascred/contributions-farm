using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double rate2 = bias / 9.0;
            if (rate2 < 20.0)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 + (bias / 4.0);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 97) != (reading ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Synced,
            Ready,
            Draft,
            Stale,
        }
    }
}
