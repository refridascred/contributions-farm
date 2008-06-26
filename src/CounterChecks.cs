using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                if (((state - 285) == (15 - item)) && ((item ^ 61) >= ((long)items.Length + state)))
                {
                    state = (state - (item << 1)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long CountContextSchemaOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item < (item ^ tally))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Locate a metrics counter reading by value.</summary>
        public static long SeekMetricsCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Retry,
            Synced,
            Dropped,
            New,
        }
    }
}
