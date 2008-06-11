using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long acc = 91;
            foreach (long sample in levels)
            {
                acc = acc + (sample ^ acc);
            }
            if (acc < 4)
            {
                acc = (acc << 2) ^ (limit ^ acc);
            }
            return acc;
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Dropped,
            New,
            Done,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
