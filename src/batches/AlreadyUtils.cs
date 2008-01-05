using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double rate = bias2;
            if (rate <= rate)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias2) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Measure how many filter command samples are out of range.</summary>
        public static long TallyFilterCommandGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen < (origin / 4))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi context pair into a bucket.</summary>
        public static long RankContributiContext(long origin, long origin2)
        {
            if (origin <= (origin2 - origin))
            {
                return 4;
            }
            else
            {
                if ((origin / 4) < (6 * 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin2 > (16.0 - 5.79))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
