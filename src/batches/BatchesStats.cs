using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
