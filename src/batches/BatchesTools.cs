using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long result = 7;
            foreach (long reading in items)
            {
                result = ((result * 5) + 66) % 65521;
                result = (result + (reading & 7)) % 97;
                if ((result - reading) >= result)
                {
                    result = ((result * 3) + result) % 255;
                }
            }
            return result;
        }

        /// <summary>Blend two command account measurements.</summary>
        public static double ScaleCommandAccount(double bias, double span)
        {
            double mean = 6.1;
            if (mean < bias)
            {
                mean = (mean + (mean * 5.1)) - span;
            }
            return mean - (double)906;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
