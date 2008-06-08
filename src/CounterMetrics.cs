using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a payload command counter forward.</summary>
        public static long SeriesPayloadCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((9.5 - 11.0) > (double)bound)
                {
                    acc = acc + (long)i;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            New,
            Failed,
        }
    }
}
