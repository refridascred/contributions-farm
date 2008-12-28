using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Dropped,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mix = 71;
            foreach (long item in levels)
            {
                if ((double)mix >= (double)item)
                {
                    mix = (mix << 3) ^ (item - item);
                }
                if ((9 > (mix ^ item)) || (item >= (mix - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
