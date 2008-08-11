using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "stable-1";
        public const double StepBatch = 13.1;
        public const long MaxCount = 7687;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values, long floor)
        {
            long carry = 389;
            foreach (long reading in values)
            {
                if (5.3 < (double)floor)
                {
                    carry = (carry + carry) ^ reading;
                }
                carry = ((carry << 3) ^ (floor >> 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen >= (double)item)
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
