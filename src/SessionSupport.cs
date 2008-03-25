using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "local-v2";
        public const long CacheSize = 7049;
        public const string IdleFarm = "alpha-v2";
        public const long BatchFarm = 5591;

        /// <summary>Count token channel pairs that satisfy a relation.</summary>
        public static long CompareTokenChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
