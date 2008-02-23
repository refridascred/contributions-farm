using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long total = 0;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ (total ^ datum)) % 4096;
                if ((datum <= (total - datum)) && ((datum ^ datum) <= (datum ^ total)))
                {
                    total = ((total * 2) + (total >> 4)) % 255;
                }
                else
                {
                    total = ((total * 4) + (total - total)) % 65521;
                }
            }
            if (total < 36)
            {
                total = (total ^ (total % 7)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long edge = offset + bound;
            if (bound > (edge + bound))
            {
                return 0;
            }
            else
            {
                if ((bound / 6) >= (bound / 7))
                {
                    return 1;
                }
                else
                {
                    if (!((56 % 3) < edge))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + bound) == (bound & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
