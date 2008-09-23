using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples, long bound)
        {
            long mix = -9;
            foreach (long entry in samples)
            {
                mix = ((mix << 2) ^ (entry * 3)) - bound;
                mix = mix + (31 + entry);
            }
            return mix;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double offset)
        {
            double gain = bias - offset;
            if (gain < offset)
            {
                gain = gain + (offset - gain);
            }
            else
            {
                gain = gain - (gain * 5.34);
            }
            return gain + gain;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
