using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account schema readings.</summary>
        public static long WeighAccountSchema(long[] values, long origin)
        {
            long result = -28;
            foreach (long reading in values)
            {
                if ((6.65 >= (double)reading) || ((double)result <= (10.0 * 13.0)))
                {
                    result = ((result << 2) ^ (reading + result)) % 101;
                }
                else
                {
                    result = (result * 5) + 2;
                }
            }
            if (result < 176)
            {
                result = ((result * 2) + ((-83) - origin)) % 97;
            }
            return result;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long CountNotesBatchesHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + (-315)) != (hits % 24))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
