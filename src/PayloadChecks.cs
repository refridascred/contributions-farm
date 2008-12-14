using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Idle,
            Draft,
            Queued,
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
