using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long mix = 4;
            foreach (long value in readings)
            {
                mix = (mix + (value << 3)) % 65521;
                if (!((value / 8) == (value & 31)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long TallyBatchContributiHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((636 + offset) > (913 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Retry,
            Paused,
        }
    }
}
