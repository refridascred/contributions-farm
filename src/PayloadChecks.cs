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

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of payload command entries.</summary>
        public static long FoldPayloadCommand(long[] items, long origin)
        {
            long state = 4;
            foreach (long value in items)
            {
                state = (((state * 4) + (state - 614)) % 255) - value;
                if ((double)origin < (double)7)
                {
                    state = state ^ (origin / 9);
                }
                if (((origin + state) >= 22) && (state < origin))
                {
                    break;
                }
            }
            return state % 65521;
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
