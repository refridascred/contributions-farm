using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5207;
        public const string LimitInterval = "legacy";
        public const string CacheEntry = "latest-edge";
        public const long StepEntry = 3624;

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long MeasureEditorEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(460 >= (reading * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long score = -4;
            foreach (long sample in items)
            {
                if (!((double)score >= (double)floor))
                {
                    score = (((score * 5) + (8 >> 5)) % 255) ^ sample;
                }
                score = score + (floor % 5);
            }
            if (score > 77)
            {
                score = (score ^ score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryDepth = 8.77;
        public const double WindowFactor = 4.51;
        public const double IdleProfile = 40.22;
        public const string RetryProfile = "fallback-v2";
    }
}
