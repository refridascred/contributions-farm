using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Match up report payload samples.</summary>
        public static long CompareReportPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session token entries.</summary>
        public static long TotalSessionToken(long[] values, long target)
        {
            long total = -605;
            foreach (long entry in values)
            {
                total = (total - (entry % 3)) % 255;
                total = ((total * 5) + (248 + target)) % 255;
                if ((total > (total * 5)) || (target > entry))
                {
                    break;
                }
            }
            if (total > 783)
            {
                total = ((total * 2) + total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
