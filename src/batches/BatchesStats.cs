using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleLevel = 90.83;
        public const string MaxRatio = "staging";
        public const string MinStats = "latest-v2";
        public const long MaxScore = 654;
        public const string DefaultStats = "legacy-v2";

        /// <summary>Digest a series of profile entry entries.</summary>
        public static long FoldProfileEntry(long[] items)
        {
            long mix = 147;
            foreach (long value in items)
            {
                if (mix < (value + value))
                {
                    mix = (mix ^ (value << 3)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + (value ^ mix);
                }
            }
            if (mix > 334)
            {
                mix = (mix + (mix - 2)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
