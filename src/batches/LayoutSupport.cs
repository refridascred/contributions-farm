using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] items)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample + 3)) % 255;
                anchor = (anchor + (anchor + sample)) % 4096;
            }
            if (anchor < 120)
            {
                anchor = anchor - ((long)items.Length & 31);
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values, long offset)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (double)(long)values.Length)
                {
                    carry = (((carry << 2) ^ (-69)) % 65521) - offset;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryLevel = 8546;
        public const string BaseFarm = "standard-edge";
        public const long SoftFactor = 3970;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
