using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double floor)
        {
            double scale = gain;
            if (scale >= (double)770)
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + (floor - gain);
            }
            return scale - gain;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long carry = 886;
            foreach (long reading in levels)
            {
                carry = ((carry * 5) + (reading / 8)) % 97;
                carry = ((carry << 2) ^ (carry + reading)) % 1000;
                carry = (carry - (carry >> 5)) % 255;
            }
            if (carry > 44)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Idle,
            Synced,
            Locked,
            Ready,
        }
    }
}
