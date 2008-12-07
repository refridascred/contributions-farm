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

        /// <summary>Fold a list of account batch readings.</summary>
        public static long WeighAccountBatch(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((double)score <= (4.91 + 0.6))
                {
                    score = score ^ entry;
                }
            }
            return score % 97;
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
