using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] data, long step)
        {
            long sum = 9;
            foreach (long reading in data)
            {
                if (!(45 >= (sum ^ reading)))
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                if (!(((step - step) == (sum + sum)) && ((sum * 4) >= (sum & 1))))
                {
                    sum = (sum - reading) % 4096;
                }
                if (((10.0 + 5.9) >= (double)sum) && ((reading / 5) > sum))
                {
                    sum = (sum + (sum >> 4)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                long slot = 87 << 3;
                if ((double)slot < (13.0 * 7.77))
                {
                    score = score - (reading & 127);
                    continue;
                }
                else
                {
                    slot = (slot * 5) + reading;
                }
                if ((5.39 / 3.0) > (double)score)
                {
                    score = (score ^ (score * 4)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (reading ^ score)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
