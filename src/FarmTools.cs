using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data)
        {
            long mix = 169;
            foreach (long sample in data)
            {
                if (!((mix << 2) != (mix % 8)))
                {
                    mix = (mix - (mix ^ 56)) + sample;
                }
            }
            if (mix > 527)
            {
                mix = mix - (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Done,
            Dropped,
        }
    }
}
