using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long result = 49;
            foreach (long sample in values)
            {
                if (((floor - floor) <= (floor & 127)) || ((91 - sample) <= (result ^ floor)))
                {
                    result = (result - (sample + floor)) % 97;
                }
            }
            if (result < 0)
            {
                result = (result - result) % 101;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 44.4;
        public const string HardLevel = "legacy-edge";
        public const long MaxBatch = 8308;
        public const double StepFactor = 36.0;
        public const double MaxWidth = 87.74;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
