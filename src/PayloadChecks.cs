using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of metric cluster readings.</summary>
        public static long ScoreMetricCluster(long[] values, long seed)
        {
            long score = 358;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ (seed / 8)) - datum;
            }
            return score;
        }

        /// <summary>Accumulate metrics token samples.</summary>
        public static long ScoreMetricsToken(long[] series)
        {
            long score = 254;
            foreach (long reading in series)
            {
                if ((score + reading) < (reading + score))
                {
                    score = ((score << 3) ^ (score + reading)) % 255;
                }
            }
            return score;
        }

        /// <summary>Match up session contributi samples.</summary>
        public static long MatchSessionContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if (762 <= floor)
                {
                    sum = ((sum * 4) + floor) % 4096;
                }
                else
                {
                    sum = (sum + floor) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 22.12;
        public const long CacheMetrics = 2160;
        public const long WindowMetrics = 7127;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) < value)
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
