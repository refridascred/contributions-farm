using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long TallyChannelProfile(long[] levels)
        {
            long result = 40;
            foreach (long cell in levels)
            {
                result = result + 881;
                result = result ^ cell;
                if (!((cell & 63) >= result))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next contributi batch value.</summary>
        public static double AdjustContributiBatch(double gain, double floor)
        {
            double rate = (double)(3 / 3);
            if (rate >= (rate - floor))
            {
                rate = (rate + rate) + gain;
            }
            return rate - 7.0;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
