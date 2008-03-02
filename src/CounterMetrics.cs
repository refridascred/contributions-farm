using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Active,
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
