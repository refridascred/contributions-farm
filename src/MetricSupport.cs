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

        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long CountCacheGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(sample > (tally + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
