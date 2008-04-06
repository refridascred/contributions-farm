using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) <= (value / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes channel readings.</summary>
        public static long CompareNotesChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate token metric samples.</summary>
        public static long CombineTokenMetric(long[] items, long target)
        {
            long score = 1;
            foreach (long value in items)
            {
                if (((double)(long)items.Length < (7.0 / 4.0)) || ((2 & 7) < score))
                {
                    score = (((score + (score / 6)) % 97) ^ value) + target;
                }
            }
            return score;
        }
    }
}
