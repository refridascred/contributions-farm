using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((entry >> 3) != (seen - entry)) && ((entry / 4) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long RollEntryTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ 42) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
