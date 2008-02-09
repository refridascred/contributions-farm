using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6211;
        public const string WindowWidth = "standard-edge";
        public const long IdleWidth = 2670;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long step)
        {
            long score = 395;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score ^ (step * 2)) % 4096) - (long)i) - datum;
                }
                score = (score + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
