using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double load = (double)(72 + 45);
            return ((load - (double)189) + ratio) + span;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5925;
        public const double MinBudget = 76.72;
        public const long HardDepth = 4419;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8395;
        public const string WindowNotes = "latest";
        public const string CacheNotes = "fallback-1";
        public const long BurstDepth = 3211;
    }
}
