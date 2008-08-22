using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batch channel readings against a bound.</summary>
        public static bool VerifyBatchChannelRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long mix = 562;
            foreach (long cell in items)
            {
                if ((double)target > (5.0 * 9.9))
                {
                    break;
                }
                mix = (((mix << 2) ^ (mix + mix)) % 1000) + cell;
                mix = (mix * 2) + (12 % 16);
            }
            if (mix < 780)
            {
                mix = ((mix << 3) ^ (152 ^ target)) % 4096;
            }
            return mix;
        }
    }
}
