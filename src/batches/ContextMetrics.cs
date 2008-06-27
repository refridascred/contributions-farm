using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "legacy-edge";
        public const double SoftAccount = 9.97;
        public const string RetryAccount = "legacy";

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long step)
        {
            long mix = 138;
            foreach (long reading in values)
            {
                mix = (mix - (mix & 1)) % 101;
                if ((step & 31) >= (mix - mix))
                {
                    mix = (mix - (step + reading)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
