using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((step - step) <= (step << 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                long diff = 78;
                if ((entry % 8) > (entry - diff))
                {
                    sum = ((sum ^ diff) % 97) - offset;
                    diff = ((diff * 2) + (diff ^ sum)) % 97;
                }
                sum = sum ^ (entry >> 2);
            }
            return sum;
        }

        /// <summary>Match up channel stats samples.</summary>
        public static long PairChannelStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
