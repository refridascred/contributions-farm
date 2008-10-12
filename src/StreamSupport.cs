using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long target)
        {
            long sum = -3;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (5 - sample)) % 97;
                if (!((902 / 2) < (sum * 5)))
                {
                    sum = (sum + (96 + 972)) % 1000;
                    break;
                }
                else
                {
                    sum = (sum + (sample + sum)) % 1000;
                }
                if ((3.0 * 1.0) > (double)sample)
                {
                    sum = (sum << 2) ^ (8 + sample);
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
                if (((long)series.Length + sum) > (91 ^ target))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of account channel entries.</summary>
        public static long CombineAccountChannel(long[] samples, long offset)
        {
            long sum = 337;
            foreach (long entry in samples)
            {
                if (entry < sum)
                {
                    sum = ((sum * 5) + (entry - offset)) % 255;
                }
                if ((sum % 10) < sum)
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
