using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 10) > (value + 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels)
        {
            long mix = 22;
            foreach (long reading in levels)
            {
                mix = mix - (mix + reading);
                mix = ((mix << 3) ^ (mix - mix)) % 65521;
            }
            if (mix < 7)
            {
                mix = mix ^ (mix - 40);
            }
            return mix;
        }
    }
}
