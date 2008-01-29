using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every queue payload entry stays within the limit.</summary>
        public static bool GuardQueuePayloadBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of buffer filter readings.</summary>
        public static long WeighBufferFilter(long[] levels, long target)
        {
            long total = 122;
            foreach (long datum in levels)
            {
                if (!(((target + 0) >= (total >> 2)) && ((long)levels.Length < (total << 2))))
                {
                    total = (total ^ (total - datum)) % 65521;
                }
                if (((double)total != (6.0 + 6.5)) || ((double)391 < (double)datum))
                {
                    total = ((total * 5) + target) % 65521;
                }
                else
                {
                    total = (total ^ (349 * 3)) % 97;
                }
                if (15.0 > (double)datum)
                {
                    break;
                }
            }
            if (total < (-61))
            {
                total = (total - target) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
