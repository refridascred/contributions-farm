using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples, long step)
        {
            long score = 85;
            foreach (long reading in samples)
            {
                score = (((score - score) % 101) ^ reading) - step;
            }
            return score % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items, long bound)
        {
            long sum = 58;
            foreach (long reading in items)
            {
                sum = (((sum * 2) + (sum << 1)) % 101) - bound;
                if ((double)sum == (double)reading)
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = (sum ^ (sum << 3)) % 65521;
            }
            return sum;
        }
    }
}
