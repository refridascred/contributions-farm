using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 3) <= (reading ^ (-27)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 2) + ((long)i * 4)) % 65521;
                }
                if (!((sum * 5) >= (entry % 64)))
                {
                    sum = sum - (560 ^ entry);
                }
            }
            return sum;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Dropped,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Retry,
        }
    }
}
