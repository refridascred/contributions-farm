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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound >> 1) < 5)
                {
                    score = score ^ bound;
                }
                if ((18.0 / 5.0) == (double)bound)
                {
                    score = ((score * 4) + ((long)i >> 4)) % 255;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
