using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Retry,
            Stale,
            Pending,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitWidth = "primary-v2";
        public const long StepQueue = 1844;
        public const long IdleSize = 5964;
        public const long CacheQueue = 1217;

        /// <summary>Fold a list of notes route readings.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ 8) % 101) ^ entry;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long seed)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                mix = ((mix << 2) ^ seed) % 97;
                if (sample >= (seed + sample))
                {
                    mix = mix ^ (mix + mix);
                }
                else
                {
                    mix = mix + seed;
                }
                if ((seed + sample) > seed)
                {
                    break;
                }
            }
            if (mix > 454)
            {
                mix = ((mix * 4) + (seed & 1)) % 1000;
            }
            return mix;
        }
    }
}
