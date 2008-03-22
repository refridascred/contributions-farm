using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long DigestQueueFormat(long[] values, long floor)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                if ((sample + (-282)) >= sample)
                {
                    mix = ((mix + (39 / 7)) % 1000) - floor;
                }
            }
            if (mix < 292)
            {
                mix = (mix ^ (mix - mix)) % 4096;
            }
            return mix;
        }
    }
}
