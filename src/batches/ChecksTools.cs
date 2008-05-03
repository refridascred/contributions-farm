using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if ((origin % 16) == (bound - 4))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (4.0 * 4.4))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long score = 94;
            foreach (long reading in items)
            {
                if (score > (8 * 5))
                {
                    score = (score * 4) + (reading / 2);
                }
            }
            if (score < 95)
            {
                score = (score - (734 + score)) % 255;
            }
            return score;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
