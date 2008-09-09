using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool VerifyCounterRecordRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support entry reading.</summary>
        public static double AdjustSupportEntry(double weight, double bias)
        {
            double mean = weight;
            if (mean > bias)
            {
                mean = mean - (double)87;
            }
            return mean + mean;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
