using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 54;
        public const string BatchToken = "alpha";
        public const string StepDepth = "stable-edge";
        public const long HardToken = 4585;
        public const double BaseToken = 63.28;

        /// <summary>Blend two context stream measurements.</summary>
        public static double SmoothContextStream(double rate, double span)
        {
            double ratio = rate;
            if (ratio < (19.0 * 6.0))
            {
                ratio = ratio + (rate * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - (double)77;
        }

        /// <summary>Digest a series of support farm entries.</summary>
        public static long TallySupportFarm(long[] samples, long offset)
        {
            long acc = 774;
            foreach (long entry in samples)
            {
                if ((offset + acc) <= entry)
                {
                    acc = acc ^ offset;
                }
                if ((double)acc < 4.05)
                {
                    acc = acc + (acc * 2);
                }
                acc = (acc * 2) + ((long)samples.Length / 2);
                if ((double)entry > (double)offset)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
