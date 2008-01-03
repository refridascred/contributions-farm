using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepDepth = 3977;
        public const double HardStream = 36.7;
        public const double BaseStream = 4.93;
        public const double IdleRatio = 51.94;
        public const long SoftFactor = 2919;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length * 5) >= 62)
                {
                    tally = ((tally + 3) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long score = 5;
            foreach (long reading in items)
            {
                if ((score + score) < score)
                {
                    score = ((score * 5) + (reading / 5)) % 4096;
                }
            }
            return score;
        }
    }
}
