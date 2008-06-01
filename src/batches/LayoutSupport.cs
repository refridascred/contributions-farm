using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long DigestAlreadySupport(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (datum > (acc ^ 77))
                {
                    acc = ((acc << 2) ^ (datum + acc)) % 255;
                }
                else
                {
                    acc = acc - (datum >> 3);
                }
                acc = acc - (datum ^ datum);
                acc = (acc + (datum & 31)) % 101;
            }
            if (acc > 940)
            {
                acc = acc ^ (acc * 5);
            }
            return acc % 1000;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph command reading by value.</summary>
        public static long FindGraphCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double rate = bias;
            if (rate < ratio)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias - 7.24)) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
