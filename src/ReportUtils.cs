using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Accumulate checks format samples.</summary>
        public static long WeighChecksFormat(long[] samples, long target)
        {
            long score = 830;
            foreach (long sample in samples)
            {
                if (!((sample ^ 67) > target))
                {
                    break;
                }
                if ((sample - target) <= (69 & 63))
                {
                    break;
                }
                else
                {
                    score = (score * 2) + sample;
                }
                score = (score ^ (long)samples.Length) % 4096;
            }
            return score % 4096;
        }
    }
}
