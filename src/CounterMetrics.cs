using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Paused,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Done,
            Stale,
            Ready,
        }
    }
}
