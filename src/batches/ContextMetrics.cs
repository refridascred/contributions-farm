using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate editor batch samples.</summary>
        public static long ScoreEditorBatch(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = (state ^ value) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings)
        {
            long sum = 96;
            foreach (long reading in readings)
            {
                if ((double)sum <= (8.0 / 4.0))
                {
                    sum = (sum ^ (sum * 5)) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Match up cluster context samples.</summary>
        public static long OverlapClusterContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            if ((6 >> 1) < (99 - offset))
            {
                return 1;
            }
            else
            {
                if ((8.96 - 1.9) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((4.28 * 7.0) != (double)offset) && ((offset & 127) != (offset ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (origin >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Retry,
            Draft,
            Pending,
            Queued,
        }
    }
}
