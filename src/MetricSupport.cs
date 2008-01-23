using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate batch buffer readings against a bound.</summary>
        public static bool VerifyBatchBufferRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (2.52 > (double)sample)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
