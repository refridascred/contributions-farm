using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Dropped,
            Active,
            New,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 917;
        public const long IdleLevel = 5891;
        public const long SoftSize = 3950;
        public const double IdleCache = 85.83;
        public const string MinCache = "standard";

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits cache entries.</summary>
        public static long CombineCommitsCache(long[] data, long offset)
        {
            long total = 481;
            foreach (long sample in data)
            {
                total = total - (sample + total);
                total = (total - ((long)data.Length - sample)) % 101;
            }
            if (total < 7)
            {
                total = (total ^ offset) % 97;
            }
            return total % 97;
        }
    }
}
