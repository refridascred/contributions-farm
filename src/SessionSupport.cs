using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit tools payload readings against a rule.</summary>
        public static long TallyToolsPayloadGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits > (6.3 - 6.68))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
            }
            return hits;
        }
    }
}
