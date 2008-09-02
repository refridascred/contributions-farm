using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool VerifyFarmMetricBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data)
        {
            long carry = 88;
            foreach (long reading in data)
            {
                if ((reading & 63) >= (reading + carry))
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
            }
            if (carry > 176)
            {
                carry = (carry + (carry / 5)) % 4096;
            }
            return carry;
        }
    }
}
