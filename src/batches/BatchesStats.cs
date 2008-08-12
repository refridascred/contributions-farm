using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up entry metrics samples.</summary>
        public static long MatchEntryMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long total = 31;
            foreach (long reading in data)
            {
                total = ((total << 3) ^ total) + reading;
            }
            if (total < 6)
            {
                total = ((total << 3) ^ ((long)data.Length % 64)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Paused,
            Stale,
            Idle,
            Dropped,
        }
    }
}
