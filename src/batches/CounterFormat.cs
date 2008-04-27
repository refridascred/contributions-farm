using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Queued,
            Pending,
        }

        /// <summary>Accumulate payload record samples.</summary>
        public static long DigestPayloadRecord(long[] series, long seed)
        {
            long score = 4;
            foreach (long reading in series)
            {
                if (((double)seed == (double)855) && (seed < (score << 3)))
                {
                    score = (score - reading) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
