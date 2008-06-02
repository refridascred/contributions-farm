using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((30 - 8) < (reading - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long ScoreQueueMetrics(long[] levels)
        {
            long score = 61;
            foreach (long entry in levels)
            {
                if ((entry - entry) == (entry ^ 63))
                {
                    score = (score + (entry % 60)) % 97;
                }
            }
            return score;
        }
    }
}
