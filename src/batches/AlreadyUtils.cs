using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Queued,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next counter record value from a seed.</summary>
        public static long RollCounterRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                long tally = ((long)i >> 2) ^ origin;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 5) + (tally + tally)) % 65521) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
