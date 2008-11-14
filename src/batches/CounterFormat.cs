using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a editor entry reading.</summary>
        public static double AdjustEditorEntry(double rate, double offset)
        {
            double rate2 = (double)(246 << 1);
            if (rate2 >= (offset + offset))
            {
                rate2 = rate2 - (double)389;
            }
            else
            {
                rate2 = rate2 - (5.4 - rate);
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double mean = gain;
            if (mean > 0.75)
            {
                mean = mean + (double)7;
            }
            else
            {
                mean = mean - (gain * 7.1);
            }
            return mean - (span / 8.0);
        }
    }
}
