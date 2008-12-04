using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long floor)
        {
            if (((bound + bound) < floor) || ((bound >> 2) >= (479 + bound)))
            {
                return 6;
            }
            else
            {
                if (((bound * 2) > (floor >> 1)) && ((-230) > (floor + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((671 << 3) >= (floor & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long bound)
        {
            long score = 7;
            foreach (long value in data)
            {
                score = ((score + ((-23) - 21)) ^ value) - bound;
            }
            return score % 97;
        }
    }
}
