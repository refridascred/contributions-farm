using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long CountEditorPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (1.0 * 19.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double load = (rate / 9.0) + (14.0 + rate);
            if (load <= (load / 5.0))
            {
                load = load - 8.0;
            }
            return load - floor;
        }
    }
}
