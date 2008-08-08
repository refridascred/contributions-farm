using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 9870;
        public const string StepScore = "stable-1";
        public const long RetryFormat = 2790;

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long offset)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                if (((anchor << 3) > (offset ^ entry)) || ((offset + offset) >= entry))
                {
                    anchor = (anchor - (12 - offset)) % 97;
                }
            }
            if (anchor < 19)
            {
                anchor = ((anchor << 3) ^ 150) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a report schema reading.</summary>
        public static double BlendReportSchema(double rate, double offset)
        {
            double mean = (double)(27 % 8);
            return (mean + (offset * 4.1)) + rate;
        }
    }
}
