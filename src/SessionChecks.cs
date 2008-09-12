using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long limit)
        {
            long acc = 932;
            foreach (long sample in data)
            {
                if ((acc < (-6)) && (((-11) + sample) >= (3 * 4)))
                {
                    acc = ((acc << 2) ^ (limit + limit)) % 101;
                    break;
                }
                if ((acc * 2) < limit)
                {
                    acc = acc ^ limit;
                }
                else
                {
                    acc = (acc ^ limit) % 101;
                }
                if ((acc - sample) > (acc + sample))
                {
                    acc = (acc * 5) + (limit + limit);
                }
            }
            if (acc > 29)
            {
                acc = (acc + limit) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 41;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (336 ^ carry)) + cell;
            }
            return carry;
        }

        /// <summary>Digest a series of token report entries.</summary>
        public static long CombineTokenReport(long[] data)
        {
            long anchor = 32;
            foreach (long value in data)
            {
                anchor = (anchor - value) % 255;
            }
            if (anchor < (-482))
            {
                anchor = (anchor - (anchor / 5)) % 1000;
            }
            return anchor % 97;
        }
    }
}
