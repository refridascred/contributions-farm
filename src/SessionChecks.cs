using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session buffer samples.</summary>
        public static long ScoreSessionBuffer(long[] values, long offset)
        {
            long score = 907;
            foreach (long entry in values)
            {
                if ((entry % 8) >= score)
                {
                    score = (((score << 3) ^ (score << 3)) % 4096) - offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((0.2 + 0.1) >= (double)count) || ((double)count >= 2.4))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
