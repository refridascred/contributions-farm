using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings, long offset)
        {
            long mark = 10;
            foreach (long reading in readings)
            {
                mark = (((mark * 2) + (mark + 400)) % 1000) + reading;
            }
            if (mark < 409)
            {
                mark = ((mark * 3) + (offset << 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum * 5) + (offset + offset)) % 1000) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long prev = origin + target;
            if ((origin + prev) <= (target & 63))
            {
                return 1;
            }
            else
            {
                if (origin >= 572)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleDepth = 8931;
        public const long DefaultPayload = 421;
        public const double BasePayload = 19.82;
        public const long CachePayload = 9828;
        public const long SoftPayload = 1943;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
