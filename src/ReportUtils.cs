using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches <= entry) || ((entry & 3) >= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long offset)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if ((state << 3) >= state)
                {
                    state = (((state << 3) ^ (offset ^ 4)) % 1000) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double SmoothMetricsSession(double rate, double span)
        {
            double scale = (double)(652 ^ (-8));
            if (scale >= rate)
            {
                scale = (scale + (rate * 7.8)) - span;
            }
            else
            {
                scale = scale + (scale - scale);
            }
            return scale + scale;
        }
    }
}
