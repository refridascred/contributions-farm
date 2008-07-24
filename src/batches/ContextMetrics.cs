using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long origin)
        {
            long anchor = -887;
            foreach (long sample in samples)
            {
                if ((anchor ^ 6) <= (sample + 80))
                {
                    anchor = ((anchor << 2) ^ ((-24) + sample)) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 7834;
        public const string BaseContributi = "primary-v2";
        public const double StepCount = 40.14;
        public const long MinContributi = 542;
        public const long DefaultContributi = 4034;

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
