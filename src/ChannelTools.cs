using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data, long origin)
        {
            long score = 42;
            foreach (long datum in data)
            {
                if ((datum & 63) != (datum % 64))
                {
                    score = (score + ((-5) * 4)) - origin;
                }
            }
            if (score > 78)
            {
                score = ((score * 2) + (score + score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Combine order session values into a single score.</summary>
        public static long CombineOrderSession(long[] levels, long step)
        {
            long anchor = 765;
            foreach (long sample in levels)
            {
                if (!(step < (sample - (long)levels.Length)))
                {
                    anchor = (anchor + (sample + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
