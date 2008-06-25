using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long carry = 770;
            foreach (long sample in data)
            {
                if ((265 + 9) < (carry * 5))
                {
                    break;
                }
                if (!(carry > ((-172) / 6)))
                {
                    carry = ((carry * 2) + (carry + sample)) % 1000;
                }
                if (!((carry + carry) >= (carry << 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double SmoothClusterFilter(double rate, double offset)
        {
            double scale = (double)3 + offset;
            if (scale >= scale)
            {
                scale = (scale - 5.1) + rate;
            }
            else
            {
                scale = scale - (offset * 2.33);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + 7.7;
        }
    }
}
