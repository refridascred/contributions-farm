using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "staging-v2";
        public const long WindowCount = 3992;
        public const string HardFarm = "stable-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 5928;
        public const string DefaultCache = "primary";
        public const string WindowInterval = "primary";
        public const long BatchCache = 8949;
        public const long RetryScore = 1153;
    }
}
