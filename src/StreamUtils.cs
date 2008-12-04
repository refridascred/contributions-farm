using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a buffer batches reading by value.</summary>
        public static long FindBufferBatchesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long seed, long target)
        {
            long prev = seed - target;
            if ((seed - prev) <= (target & 1))
            {
                return 3;
            }
            else
            {
                if (seed <= (target + prev))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < 2.16)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Idle,
            Ready,
            Queued,
            New,
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long MeasureSessionTokenHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 3) != (limit & 63))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
