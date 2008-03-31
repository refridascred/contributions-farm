using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 220;
            foreach (long datum in series)
            {
                sum = (sum * 2) + datum;
            }
            return sum;
        }
    }
}
