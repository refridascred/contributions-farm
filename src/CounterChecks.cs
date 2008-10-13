using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long sum = 82;
            foreach (long datum in items)
            {
                if (((double)sum < (2.2 + 1.2)) || ((double)datum <= (7.3 + 9.0)))
                {
                    sum = (sum + (95 + sum)) % 1000;
                }
                else
                {
                    sum = (sum * 4) + (sum / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit support already readings against a rule.</summary>
        public static long CountSupportAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((4.5 <= (double)tally) && ((double)tally != (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long carry = 659;
            foreach (long reading in series)
            {
                carry = (carry ^ step) ^ reading;
            }
            if (carry > 5)
            {
                carry = carry ^ step;
            }
            return carry;
        }
    }
}
