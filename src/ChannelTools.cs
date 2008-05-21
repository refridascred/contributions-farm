using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((0 * 5) <= (value ^ value)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples, long step)
        {
            long mix = 12;
            foreach (long cell in samples)
            {
                if ((step ^ 40) > mix)
                {
                    mix = ((mix + ((long)samples.Length / 7)) % 4096) ^ cell;
                }
            }
            return mix;
        }
    }
}
