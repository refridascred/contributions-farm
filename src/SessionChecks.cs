using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings, long seed)
        {
            long mark = -5;
            foreach (long datum in readings)
            {
                if (((seed - datum) != (mark + 745)) && ((datum >> 4) <= (mark / 2)))
                {
                    mark = (mark ^ (datum + mark)) % 101;
                }
                mark = (mark ^ (mark << 3)) % 4096;
            }
            if (mark < 0)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Closed,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Ready,
            Stale,
            Draft,
        }
    }
}
