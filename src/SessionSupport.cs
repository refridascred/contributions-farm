using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Draft,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] readings, long bound)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if ((-5) >= item)
                {
                    score = ((score ^ (129 * 4)) % 97) + bound;
                }
            }
            return score % 97;
        }
    }
}
