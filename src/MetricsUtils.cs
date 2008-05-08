using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((1.97 * 7.61) >= (double)hits) || (((long)samples.Length + (-809)) < value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values, long target)
        {
            long total = 805;
            foreach (long reading in values)
            {
                if (!((target - (-28)) <= (reading + reading)))
                {
                    total = (total - (reading >> 2)) % 65521;
                }
                if (((total % 97) < reading) || (reading <= (total ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the format farm series from a seed.</summary>
        public static long RollFormatFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (target >= score)
                {
                    score = ((score * 2) + (score - score)) % 255;
                    score = (score - 409) % 65521;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
