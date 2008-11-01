using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.0 * 7.0) >= (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if ((reading + mix) > (mix ^ reading))
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }
    }
}
