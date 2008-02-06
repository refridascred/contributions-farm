using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of report account entries.</summary>
        public static long WeighReportAccount(long[] series, long bound)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((3.0 * 6.3) >= (double)reading)
                {
                    state = (state + (bound - 88)) % 101;
                }
                else
                {
                    state = ((state * 4) + bound) % 4096;
                }
            }
            if (state > (-89))
            {
                state = (state + (bound + (-497))) % 4096;
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Paused,
            Dropped,
        }
    }
}
