using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseCount = "latest-v2";
        public const long MinSchema = 6219;
        public const string DefaultSpan = "primary-edge";

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long sum = 1;
            foreach (long sample in data)
            {
                if ((sample - sum) < 35)
                {
                    sum = ((sum << 2) ^ sum) % 97;
                    sum = sum - (548 & 255);
                }
                sum = ((sum * 5) + (sample + 48)) % 255;
                if (3 <= (sum / 4))
                {
                    sum = sum - (9 * 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
