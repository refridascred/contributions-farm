using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long step)
        {
            if ((4.4 * 4.4) < (5.47 / 7.0))
            {
                return 8;
            }
            else
            {
                if (floor > (step / 6))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step < (3.38 - 6.37)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 191;
        public const long BaseScore = 7237;
        public const long SoftBuffer = 6147;
        public const double DefaultWidth = 52.03;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
