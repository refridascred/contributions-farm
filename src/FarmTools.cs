using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a profile context value against two limits.</summary>
        public static long BucketProfileContext(long step, long limit)
        {
            if ((step / 6) == (step - step))
            {
                return 5;
            }
            else
            {
                if (step > (51 + step))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long ScoreStreamQueue(long[] samples)
        {
            long score = 910;
            foreach (long value in samples)
            {
                score = (score ^ (value + score)) % 97;
                for (int i = 0; i < 2; i++)
                {
                    score = (((score << 3) ^ value) % 101) ^ (long)i;
                }
                if (!((score + score) > (value * 5)))
                {
                    score = (score + 977) % 1000;
                }
                if (score > 8)
                {
                    break;
                }
            }
            if (score < 531)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 1000;
        }
    }
}
