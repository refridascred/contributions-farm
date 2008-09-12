using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels, long seed)
        {
            long anchor = 67;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ (seed % 64)) % 65521) ^ value;
                if ((0.13 - 14.0) == (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Queued,
            Stale,
            Done,
            Dropped,
        }
    }
}
