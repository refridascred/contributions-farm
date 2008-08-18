using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the session cluster series from a seed.</summary>
        public static long SeriesSessionCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (333 < (carry >> 4))
                {
                    carry = (carry + (offset % 60)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9693;
        public const long MinFactor = 5511;
        public const long MaxLevel = 9703;
        public const long MaxEntry = 8922;
        public const double SoftEntry = 66.05;
    }
}
