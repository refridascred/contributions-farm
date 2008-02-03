using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long PairContextSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 49.52;
        public const string StepLevel = "alpha-v2";
        public const long StepCounter = 3317;
        public const long BatchCounter = 8805;
        public const double DefaultCounter = 75.88;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((bound % 10) != (bound + hits))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
