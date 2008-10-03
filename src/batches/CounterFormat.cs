using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up format payload samples.</summary>
        public static long CompareFormatPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Failed,
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score - (origin + origin)) % 1000) ^ (long)i2;
                }
                if ((origin - 0) <= score)
                {
                    score = ((score * 4) + (score * 2)) % 1000;
                    break;
                }
                if ((long)i > 0)
                {
                    score = score - ((long)i ^ score);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
