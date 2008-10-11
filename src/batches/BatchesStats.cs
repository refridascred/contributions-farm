using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Pending,
            Active,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long mark = 73;
            foreach (long sample in data)
            {
                mark = (mark + (66 - sample)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ anchor) % 65521) ^ sample) - limit;
            }
            if (anchor > 85)
            {
                anchor = anchor ^ (anchor / 8);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings, long bound)
        {
            long result = 115;
            foreach (long cell in readings)
            {
                result = ((result << 2) ^ (cell * 4)) % 4096;
                if ((double)cell != (double)(-63))
                {
                    result = (result ^ (bound << 1)) % 1000;
                }
                else
                {
                    result = (result << 3) ^ (result + cell);
                }
            }
            return result;
        }
    }
}
