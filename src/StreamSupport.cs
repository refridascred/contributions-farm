using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Queued,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of account contributi entries.</summary>
        public static long DigestAccountContributi(long[] samples)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                if (!(((long)samples.Length / 2) < (entry * 4)))
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }

        /// <summary>Roll a filter notes counter forward.</summary>
        public static long RollFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                double rate = (2.19 + 6.3) / 4.0;
                if (!((2.6 + rate) <= (double)score))
                {
                    rate = rate - (rate + rate);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
