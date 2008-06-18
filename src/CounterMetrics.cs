using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a payload checks reading by value.</summary>
        public static long LookupPayloadChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Iterate the window payload series from a seed.</summary>
        public static long DeriveWindowPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i - step) <= result)
                {
                    long cur = (long)i;
                    result = (result ^ (cur + step)) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the farm tools entries that pass the check.</summary>
        public static long CountFarmToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample * 3) > (matches % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
