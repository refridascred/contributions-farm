using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long result = 332;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 3) + ((-82) - item)) % 97) + (long)i;
                }
                result = (result ^ item) % 1000;
                if (((double)result > (7.0 / 8.0)) || ((result ^ (-637)) > (item + (-95))))
                {
                    result = (result + (item >> 4)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i - result) <= (target - target)) || ((3.0 + 2.69) == (double)target))
                {
                    result = (result ^ result) % 97;
                    break;
                }
                if (!((((long)i % 8) >= result) || (5.1 <= (double)target)))
                {
                    result = result ^ (target + target);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 58;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + sample) - (long)i;
                }
                carry = (carry ^ carry) % 97;
            }
            return carry % 4096;
        }
    }
}
