using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batches context reading.</summary>
        public static double ScaleBatchesContext(double gain, double offset)
        {
            double gain2 = gain * 16.0;
            return (gain2 - (gain / 2.0)) + offset;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (offset * 5)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
