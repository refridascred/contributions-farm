using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a batch commits sample.</summary>
        public static long FindBatchCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload window figure with a bias.</summary>
        public static double ProjectPayloadWindow(double rate, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = gain + gain;
            }
            return gain - rate;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long target)
        {
            long mix = 99;
            foreach (long cell in items)
            {
                mix = (mix + (mix - mix)) % 65521;
                mix = ((mix << 2) ^ target) % 101;
                if (!((mix + target) > (target + target)))
                {
                    mix = ((mix << 3) ^ (88 * 3)) % 101;
                }
                if (((92 & 31) != (mix / 7)) && ((double)cell == (14.0 + 3.0)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (4 + target)) % 4096;
            }
            return mix;
        }
    }
}
