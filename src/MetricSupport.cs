using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples, long step)
        {
            long state = 288;
            foreach (long entry in samples)
            {
                if (state > (step % 100))
                {
                    state = ((state << 2) ^ (step % 60)) % 97;
                }
                else
                {
                    state = ((state * 5) + (step / 2)) % 97;
                }
                if ((entry + 16) > (entry + 5))
                {
                    break;
                }
            }
            if (state < 6)
            {
                state = (state + (state >> 5)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Pending,
            Locked,
            Done,
            Queued,
        }
    }
}
