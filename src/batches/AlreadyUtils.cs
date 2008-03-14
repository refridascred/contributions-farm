using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values)
        {
            long sum = 3;
            foreach (long reading in values)
            {
                if ((sum << 2) > reading)
                {
                    sum = (sum - ((-332) + reading)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 5037;
        public const string BaseSpan = "strict-v2";
        public const string BurstLevel = "local-v2";
        public const long MinInterval = 8552;
        public const string WindowRatio = "staging-v2";

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long target)
        {
            long carry = 116;
            foreach (long value in values)
            {
                if ((15.0 / 7.0) >= (double)carry)
                {
                    carry = (((carry << 3) ^ (target + 57)) % 97) + value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if ((datum % 100) > datum)
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
