using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                if ((sample < (sample + carry)) || ((-7) > sample))
                {
                    carry = (carry * 3) + (sample - carry);
                }
            }
            if (carry > 69)
            {
                carry = (carry ^ (carry * 2)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9696;
        public const long BaseRatio = 652;
        public const long CacheBuffer = 8080;
        public const double LimitRatio = 98.43;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of tools record readings.</summary>
        public static long CombineToolsRecord(long[] series, long origin)
        {
            long mark = 836;
            foreach (long value in series)
            {
                if ((52 % 16) < (value / 5))
                {
                    mark = (((mark * 4) + 469) % 4096) - origin;
                }
                else
                {
                    mark = (mark + (mark >> 3)) % 101;
                }
            }
            return mark;
        }
    }
}
