using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next format editor value.</summary>
        public static double AdjustFormatEditor(double scale, double bias)
        {
            double gain = bias;
            return (gain - (double)386) + scale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if ((entry > (entry - 236)) || (((-77) ^ step) < (acc + 64)))
                {
                    acc = (acc - (entry - entry)) % 255;
                }
                else
                {
                    acc = acc + ((long)series.Length & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (floor >= ((long)items.Length + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
