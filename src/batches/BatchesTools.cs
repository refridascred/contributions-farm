using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long TallySchemaProfileGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (target >= 37)
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double gain = bias * 7.79;
            if (gain < 6.1)
            {
                gain = gain + 12.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)310;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total + (total << 2)) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
