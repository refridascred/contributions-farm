using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate channel session readings against a bound.</summary>
        public static bool VerifyChannelSessionLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate entry order samples.</summary>
        public static long DigestEntryOrder(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                if ((double)cell <= (double)(-145))
                {
                    mix = ((mix << 3) ^ cell) % 255;
                    continue;
                }
                mix = (mix ^ (996 + mix)) % 97;
                if ((mix >> 1) < (cell - cell))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = ((mix * 3) + mix) % 97;
            }
            return mix % 65521;
        }
    }
}
