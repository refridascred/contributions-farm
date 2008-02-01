using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double scale, double span)
        {
            double weight = scale * 14.0;
            if (weight < (double)97)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + 9.2;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
