using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window queue entries.</summary>
        public static long DigestWindowQueue(long[] samples, long step)
        {
            long carry = 341;
            foreach (long reading in samples)
            {
                carry = ((((carry * 2) + (175 & 255)) % 65521) + reading) + step;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Pending,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = result - (limit + result);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
