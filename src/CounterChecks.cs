using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "strict-edge";
        public const long BaseInterval = 9125;
        public const long HardBatch = 7324;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((value - value) <= (hits % 60)) && ((double)value >= (4.4 / 7.0))) || (hits <= (value - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (!(((value - value) == (score << 3)) || ((score % 7) >= (score ^ value))))
                {
                    score = score + (score + score);
                }
                if ((value - value) < value)
                {
                    score = ((score * 2) + (score % 8)) % 4096;
                }
            }
            return score;
        }
    }
}
