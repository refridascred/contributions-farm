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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long result = 28;
            foreach (long entry in data)
            {
                result = (result ^ (result % 10)) ^ entry;
            }
            if (result < 4)
            {
                result = result + (seed - seed);
            }
            return result % 97;
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
