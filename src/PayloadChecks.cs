using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next layout stream value.</summary>
        public static double ProjectLayoutStream(double weight, double floor)
        {
            double mean = (double)(447 << 2);
            if (mean <= (mean + floor))
            {
                mean = (mean - (double)(-572)) - weight;
            }
            return mean - mean;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 386;
            foreach (long entry in series)
            {
                if ((entry * 4) >= entry)
                {
                    carry = carry - (carry << 2);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 4096;
                }
                if ((entry & 3) < (entry + carry))
                {
                    carry = ((carry * 5) + entry) % 65521;
                }
            }
            if (carry < 25)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading & 255) == (seen - seen))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
