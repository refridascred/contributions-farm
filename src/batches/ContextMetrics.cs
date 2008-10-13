using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            New,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long limit)
        {
            if ((seed & 1) >= (seed % 24))
            {
                return 3;
            }
            else
            {
                if ((seed + limit) < (limit ^ (-9)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) == (limit - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed + limit) >= (limit << 3)) || ((double)seed <= (16.0 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + limit) <= (hits & 7)) && ((double)reading == (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
