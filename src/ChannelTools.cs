using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = 115;
            foreach (long datum in series)
            {
                if ((double)datum <= (2.8 / 6.0))
                {
                    score = score ^ (datum + 0);
                }
            }
            return score;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
