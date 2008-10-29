using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
