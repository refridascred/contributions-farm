using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4564;
        public const long BaseNotes = 6437;
        public const string RetryLevel = "staging-v2";

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count > (7 ^ count)) && ((count + offset) == (count - count))))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                anchor = ((anchor * 4) + (anchor / 2)) ^ sample;
            }
            if (anchor > 23)
            {
                anchor = anchor + (anchor % 97);
            }
            return anchor;
        }
    }
}
