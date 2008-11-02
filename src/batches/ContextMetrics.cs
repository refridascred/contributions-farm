using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits != (4.53 + 5.69))
                {
                    hits = ((hits + 1) + entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long target)
        {
            long prev = bound + target;
            if (((target - bound) <= (target % 12)) && ((prev + target) >= prev))
            {
                return 1;
            }
            else
            {
                if ((double)90 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long MeasureContributiQueueGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 4) == (sample << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long limit)
        {
            long score = -195;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score << 3) ^ (limit / 4)) % 255) ^ (long)i;
                }
                score = score + value;
                if ((3.0 + 3.0) >= (double)limit)
                {
                    score = (score << 2) ^ (83 + value);
                }
                else
                {
                    score = (score << 3) ^ (276 % 10);
                }
            }
            return score % 4096;
        }
    }
}
