using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 6876;
        public const long BurstSession = 5505;
        public const long MaxScore = 6538;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 3997;
        public const double MinSupport = 77.53;
        public const long StepSupport = 8513;
        public const long IdleSupport = 8247;
        public const long DefaultSpan = 960;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
