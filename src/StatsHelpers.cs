using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7797;
        public const long StepWidth = 5632;
        public const string MaxScore = "cached";
        public const double SoftBatches = 23.11;
        public const long IdleFactor = 5554;

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long SeriesCommitsStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)anchor == (19.0 * 19.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor << 2) ^ (long)i;
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
