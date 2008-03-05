using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long CountQueuePayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (-1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            long step = seed + limit;
            if (!(limit > seed))
            {
                return 3;
            }
            else
            {
                if ((seed % 8) < seed)
                {
                    return 0;
                }
                else
                {
                    if (limit <= (step << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Failed,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
