using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long floor)
        {
            long state = 95;
            foreach (long entry in samples)
            {
                state = ((state * 2) + (entry + state)) - floor;
            }
            return state;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5547;
        public const double BatchBatches = 83.31;
        public const long WindowBatches = 5687;

        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long LocateBufferContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Size { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
