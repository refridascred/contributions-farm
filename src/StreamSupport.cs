using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Closed,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(3.3 <= (double)seen) || !((double)seen < (8.0 + 5.4)))
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
