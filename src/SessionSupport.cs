using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long result = 31;
            foreach (long entry in levels)
            {
                result = (((result * 5) + result) % 97) - target;
                result = (result + (entry + (long)levels.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            New,
            Active,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (23 < cell)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }
    }
}
