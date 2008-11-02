using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long acc = 353;
            foreach (long item in values)
            {
                if ((acc % 3) <= (acc >> 2))
                {
                    acc = ((acc - (acc / 2)) % 255) - item;
                }
            }
            if (acc < 4)
            {
                acc = (acc << 3) ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 746;
            foreach (long entry in levels)
            {
                anchor = anchor - (entry + entry);
                if ((entry << 1) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
