using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Queued,
            Draft,
            New,
            Locked,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Stale,
            New,
        }
    }
}
