using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)143 + (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)7) + (double)(long)i) + rate) + span;
            }
            return gain - 11.0;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings, long limit)
        {
            long mix = 43;
            foreach (long item in readings)
            {
                mix = (mix ^ (mix << 1)) + item;
            }
            if (mix > 215)
            {
                mix = (mix ^ (limit / 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long mix = 4;
            foreach (long sample in data)
            {
                mix = (mix + (989 + 38)) % 255;
                if (sample < (mix + 70))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long anchor = 431;
            foreach (long item in data)
            {
                if (!((item + anchor) > item))
                {
                    anchor = anchor - (anchor >> 5);
                }
            }
            return anchor;
        }
    }
}
