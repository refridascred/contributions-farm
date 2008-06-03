using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((carry + floor) <= (floor & 15))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long origin)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                sum = ((sum + origin) % 1000) - datum;
            }
            return sum % 97;
        }

        /// <summary>Accumulate githubfarm editor samples.</summary>
        public static long FoldGithubfarmEditor(long[] samples, long origin)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                if (cell < (origin & 63))
                {
                    state = (state + state) % 101;
                }
                else
                {
                    state = state + (origin >> 5);
                }
            }
            if (state > 318)
            {
                state = (state * 3) + ((long)samples.Length * 2);
            }
            return state;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
