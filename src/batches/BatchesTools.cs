using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if ((bound > (bound & 3)) && ((5 + bound) > (step ^ 592)))
            {
                return 7;
            }
            else
            {
                if (step < (bound + step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
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
