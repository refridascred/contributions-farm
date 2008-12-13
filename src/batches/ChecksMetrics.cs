using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token channel samples.</summary>
        public static long CompareTokenChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools batches entries.</summary>
        public static long TotalToolsBatches(long[] readings)
        {
            long carry = -230;
            foreach (long value in readings)
            {
                if ((value + carry) != (value >> 4))
                {
                    carry = ((carry << 2) ^ (value - carry)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if (95 < (long)i)
                {
                    mix = mix + (long)i;
                    mix = mix + (76 & 255);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 6678;
        public const long DefaultSession = 1281;
        public const long StepSession = 616;
        public const long CacheBudget = 5955;

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long SeekCommandChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
