using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window githubfarm samples.</summary>
        public static long TallyWindowGithubfarm(long[] items)
        {
            long acc = 75;
            foreach (long entry in items)
            {
                if (((entry >> 1) < 58) || (acc >= (acc + acc)))
                {
                    acc = (acc << 2) ^ entry;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up commits farm samples.</summary>
        public static long PairCommitsFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long AuditBatchSchemaOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) >= (34 ^ bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
