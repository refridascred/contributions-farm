using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long DigestTokenBatches(long[] samples, long target)
        {
            long anchor = 93;
            foreach (long reading in samples)
            {
                if (!((0.11 * 0.78) < (double)reading))
                {
                    anchor = (anchor ^ ((long)samples.Length << 2)) % 65521;
                }
                if (!((target > (reading + anchor)) || (target < (anchor / 3))))
                {
                    anchor = (anchor + anchor) % 97;
                }
                if ((double)target >= (5.3 + 18.0))
                {
                    anchor = (anchor ^ ((-622) - reading)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally != (17.0 + 9.1))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context queue series from a seed.</summary>
        public static long StepContextQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
