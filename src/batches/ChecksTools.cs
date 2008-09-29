using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first editor tools entry that matches the target.</summary>
        public static long FindEditorToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Draft,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultBudget = "strict-1";
        public const long BatchTimeout = 4063;
        public const long DefaultSpan = 6642;
        public const long WindowAlready = 870;
        public const long MaxAlready = 7347;
    }
}
