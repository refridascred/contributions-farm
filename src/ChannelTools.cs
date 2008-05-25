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

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long AuditOrderSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((74 >> 2) < (value << 1)) && (count >= value))
                {
                    count = count + 2;
                }
            }
            return count;
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
