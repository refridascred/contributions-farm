using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a channel format reading by value.</summary>
        public static long LookupChannelFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] series)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((double)(long)series.Length > 6.8)
                {
                    score = score + (item << 2);
                }
                if (!((item - score) <= (score & 3)))
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ (score << 3)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long DeriveMetricsOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 2) ^ (offset / 5)) % 97;
                result = result + (result % 16);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first support window entry that matches the target.</summary>
        public static long LocateSupportWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
