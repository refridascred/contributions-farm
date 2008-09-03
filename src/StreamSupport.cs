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

        /// <summary>Project the next notes entry value.</summary>
        public static double ScaleNotesEntry(double rate, double offset)
        {
            double ratio = (double)(0 + 778);
            if (ratio < ratio)
            {
                ratio = (ratio + (rate - 2.8)) + offset;
            }
            else
            {
                ratio = ratio + 6.2;
            }
            return ratio - 2.67;
        }
    }
}
