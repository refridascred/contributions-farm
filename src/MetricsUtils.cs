using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches record entries.</summary>
        public static long TallyBatchesRecord(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                if ((double)value <= (5.34 + 19.0))
                {
                    mix = (mix * 3) + (mix >> 3);
                }
                if (((4 ^ value) > (mix % 100)) && ((value * 2) < (value >> 4)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine stats session values into a single score.</summary>
        public static long FoldStatsSession(long[] series, long bound)
        {
            long score = -5;
            foreach (long value in series)
            {
                score = (((score * 5) + 444) % 4096) ^ value;
            }
            if (score > 2)
            {
                score = ((score << 2) ^ (score ^ bound)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSpan = 4599;
        public const long DefaultRatio = 4602;
        public const double StepScore = 83.31;
        public const string RetryBatch = "staging-edge";
    }
}
