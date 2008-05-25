using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up layout filter samples.</summary>
        public static long PairLayoutFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks stream value.</summary>
        public static double AdjustChecksStream(double gain, double span)
        {
            double gain2 = 2.96;
            if (gain2 >= (13.0 / 5.0))
            {
                gain2 = (gain2 + gain2) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (double)835) - (double)(long)i;
            }
            return gain2 - (gain - gain);
        }
    }
}
