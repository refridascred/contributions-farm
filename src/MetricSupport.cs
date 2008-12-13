using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double mean = (double)(41 ^ 27);
            if (mean < 3.42)
            {
                mean = (mean - (bias * 17.0)) - offset;
            }
            return mean - (double)60;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mix = -5;
            foreach (long datum in data)
            {
                if ((datum * 3) >= (mix + 87))
                {
                    mix = (mix ^ (datum + 4)) % 4096;
                }
                else
                {
                    mix = (mix + (datum << 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
