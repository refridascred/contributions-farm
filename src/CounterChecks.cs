using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Stale,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long IterateSessionSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (sum < ((long)i >> 5))
                {
                    sum = ((sum * 2) + ((long)i - sum)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (sum * 4);
                }
                if (sum <= ((long)i << 1))
                {
                    sum = (sum * 4) + (sum & 255);
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Draft,
            Pending,
            New,
            Synced,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
