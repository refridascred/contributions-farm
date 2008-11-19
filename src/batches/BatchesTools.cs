using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading >= (0 & 127)) && (tally > (tally & 31)))
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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((0.69 / 8.0) < (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Failed,
            Locked,
        }
    }
}
