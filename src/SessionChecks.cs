using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a graph tools reading by value.</summary>
        public static long LocateGraphToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels, long floor)
        {
            long result = 75;
            foreach (long sample in levels)
            {
                if ((floor & 1) == (floor / 6))
                {
                    result = ((result << 2) ^ (floor - 4)) + sample;
                }
            }
            if (result > 42)
            {
                result = (result * 2) + (floor + result);
            }
            return result % 65521;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Active,
            Closed,
            Locked,
            Synced,
        }
    }
}
