using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data, long bound)
        {
            long result = 8;
            foreach (long item in data)
            {
                if (((item * 2) != (item - bound)) || ((double)bound == (12.0 / 8.0)))
                {
                    result = result + (bound - 638);
                }
            }
            return result % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= (2.71 * 0.5))
                {
                    hits = ((hits + 3) - datum) - step;
                }
            }
            return hits;
        }
    }
}
