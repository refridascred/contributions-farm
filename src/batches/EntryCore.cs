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

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool GuardContextBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
