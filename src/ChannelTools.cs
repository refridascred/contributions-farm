using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double span)
        {
            double scale2 = (span / 3.0) / 6.0;
            if (scale2 >= (scale * 4.9))
            {
                scale2 = scale2 - span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (scale2 - scale2)) + (double)(long)i;
            }
            return scale2 - (scale2 / 3.0);
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
