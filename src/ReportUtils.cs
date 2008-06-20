using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum * 4) <= datum))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
