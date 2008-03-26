using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long acc = 513;
            foreach (long sample in data)
            {
                acc = (((acc * 2) + acc) % 65521) + sample;
            }
            return acc % 4096;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Find the first profile stats entry that matches the target.</summary>
        public static long LookupProfileStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long acc = -699;
            foreach (long sample in data)
            {
                acc = (acc ^ acc) + sample;
            }
            if (acc > (-324))
            {
                acc = (acc ^ (step >> 5)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Synced,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
