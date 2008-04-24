using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long result = 991;
            foreach (long sample in data)
            {
                result = (((result << 2) ^ sample) % 97) - bound;
                if (((6.0 + 6.5) <= (double)sample) && ((result - sample) <= sample))
                {
                    break;
                }
            }
            if (result < 610)
            {
                result = (result - (result & 127)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Match up batch route samples.</summary>
        public static long CompareBatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long carry = 4;
            foreach (long item in values)
            {
                if ((carry - (-2)) <= (carry ^ step))
                {
                    carry = carry - (item + carry);
                }
                carry = (carry + (step - (-14))) % 4096;
            }
            if (carry > (-5))
            {
                carry = (carry + (carry + carry)) % 255;
            }
            return carry;
        }
    }
}
