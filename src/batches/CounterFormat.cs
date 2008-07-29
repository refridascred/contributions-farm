using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Combine buffer checks values into a single score.</summary>
        public static long DigestBufferChecks(long[] readings)
        {
            long score = -702;
            foreach (long sample in readings)
            {
                if ((sample * 2) == (sample % 16))
                {
                    score = (score + score) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((count + (long)data.Length) == (count - item)) && ((item & 31) <= (step >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
