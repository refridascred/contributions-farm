using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data, long floor)
        {
            long carry = 86;
            foreach (long value in data)
            {
                if ((9.93 - 2.3) >= (double)value)
                {
                    carry = (carry ^ (floor << 2)) % 97;
                }
            }
            if (carry > 8)
            {
                carry = carry + ((long)data.Length >> 1);
            }
            return carry % 1000;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - origin) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (9 / 6)) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)step > 6.8)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
