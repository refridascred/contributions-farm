using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream entry readings against a rule.</summary>
        public static long TallyStreamEntryGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(seed >= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Draft,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long anchor = 23;
            foreach (long entry in readings)
            {
                if (9.0 <= (double)entry)
                {
                    anchor = (anchor - (target ^ entry)) % 97;
                }
                if ((double)anchor < 9.0)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
