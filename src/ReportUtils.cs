using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item << 2) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double bias = (double)(-8) - span;
            if (bias < (span / 8.0))
            {
                bias = (bias + 2.56) - gain;
            }
            else
            {
                bias = bias + (9.67 - bias);
            }
            return bias + (bias * 0.18);
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 97) <= matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                acc = ((acc ^ (-892)) % 65521) - offset;
                if ((5 * 5) == (reading << 1))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
