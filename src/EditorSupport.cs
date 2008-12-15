using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double ratio = (double)(305 / 2);
            if (ratio < (bias * 11.0))
            {
                ratio = ratio + bias;
            }
            return ratio + (span / 5.0);
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings, long origin)
        {
            long acc = 839;
            foreach (long reading in readings)
            {
                long delta = reading + (acc + acc);
                acc = acc + (delta + reading);
                if (((double)acc >= (6.3 - 3.0)) && ((52 + reading) >= 0))
                {
                    acc = acc - (origin - (-7));
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if (!((floor - target) == (target - target)))
            {
                return 3;
            }
            else
            {
                if ((0.46 > (double)floor) && ((target - 4) < (target & 1)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
