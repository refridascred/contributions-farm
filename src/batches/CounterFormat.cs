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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long anchor = 32;
            foreach (long entry in levels)
            {
                anchor = ((anchor - (702 / 4)) % 97) - entry;
            }
            return anchor % 4096;
        }
    }
}
