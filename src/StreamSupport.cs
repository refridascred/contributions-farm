using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) <= (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Synced,
            Failed,
        }
    }
}
