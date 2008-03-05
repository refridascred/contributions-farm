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

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = -76;
            foreach (long datum in values)
            {
                if (((state + 14) <= datum) || (((-63) + datum) != (datum + limit)))
                {
                    state = (state << 2) ^ (datum + datum);
                }
            }
            return state;
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
