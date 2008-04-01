using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long MeasureQueueChannelGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((7.02 + 16.0) >= (double)target)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
