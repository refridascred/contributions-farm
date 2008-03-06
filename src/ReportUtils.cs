using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Stale,
            New,
            Closed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data, long step)
        {
            long mix = 7;
            foreach (long value in data)
            {
                mix = (((mix << 2) ^ mix) + value) + step;
            }
            return mix % 1000;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
