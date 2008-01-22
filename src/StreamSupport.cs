using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples)
        {
            long score = 61;
            foreach (long datum in samples)
            {
                score = ((score * 3) + (datum + 623)) % 255;
                score = (score ^ (score * 3)) % 255;
            }
            if (score < 62)
            {
                score = score ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Digest a series of batch contributi entries.</summary>
        public static long TallyBatchContributi(long[] samples)
        {
            long result = 324;
            foreach (long item in samples)
            {
                if ((8.0 + 4.5) != (double)result)
                {
                    result = ((result + (result & 3)) % 255) + item;
                }
            }
            if (result > 396)
            {
                result = (result + (result ^ result)) % 101;
            }
            return result;
        }
    }
}
