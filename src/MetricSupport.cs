using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up token session samples.</summary>
        public static long MatchTokenSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.2 - 19.0) <= (double)(long)values.Length)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample ^ 145) > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
