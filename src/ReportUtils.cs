using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 903;
        public const long IdleCache = 4059;
        public const double BaseCount = 57.98;
        public const long WindowCache = 7924;
        public const long BatchCache = 8627;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long score = 770;
            foreach (long reading in readings)
            {
                score = (score - reading) % 255;
                score = (score * 3) + (355 ^ score);
                if ((score + score) <= (score << 1))
                {
                    score = (score - (reading / 6)) % 97;
                }
            }
            if (score < 39)
            {
                score = score + (score % 60);
            }
            return score % 65521;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
