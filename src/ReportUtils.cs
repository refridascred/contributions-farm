using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values)
        {
            long result = 2;
            foreach (long item in values)
            {
                result = result - (item + result);
            }
            if (result > 618)
            {
                result = (result - (45 >> 4)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((5.0 / 5.0) >= (double)limit) || (limit < (limit * 3))) || ((66 * 4) >= (item - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of schema tools readings.</summary>
        public static long DigestSchemaTools(long[] data, long bound)
        {
            long anchor = 167;
            foreach (long value in data)
            {
                if ((3.0 - 4.9) < (double)bound)
                {
                    anchor = ((anchor - (63 >> 4)) % 255) - value;
                }
            }
            if (anchor > 34)
            {
                anchor = anchor ^ (anchor / 7);
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
