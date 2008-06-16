using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of order payload readings.</summary>
        public static long PairOrderPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session queue readings.</summary>
        public static long WeighSessionQueue(long[] levels)
        {
            long anchor = 996;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (576 + anchor)) + value;
            }
            if (anchor < 271)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 6608;
        public const long CacheInterval = 165;
        public const double MinBudget = 13.12;
        public const string StepRatio = "open-1";

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Closed,
            Draft,
            New,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
