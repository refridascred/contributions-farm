using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels, long bound)
        {
            long mark = 80;
            foreach (long item in levels)
            {
                if (mark >= item)
                {
                    mark = ((mark + mark) % 4096) - bound;
                }
                else
                {
                    mark = ((mark << 3) ^ (926 + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstBudget = "fallback-v2";
        public const long LimitLevel = 7998;
        public const long MaxStream = 4084;
        public const long BaseStream = 8616;
        public const long BatchStream = 5090;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
