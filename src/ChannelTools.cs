using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double gain = weight;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - floor) - (double)(long)i;
            }
            return gain - (gain / 9.0);
        }

        /// <summary>Fold a list of notes cluster readings.</summary>
        public static long CombineNotesCluster(long[] items)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                mark = mark ^ (entry & 15);
                mark = (mark + (mark - mark)) % 1000;
            }
            if (mark < 13)
            {
                mark = ((mark << 3) ^ (87 + mark)) % 65521;
            }
            return mark;
        }
    }
}
