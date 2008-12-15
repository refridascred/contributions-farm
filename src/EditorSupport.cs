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

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8854;
        public const string CacheFilter = "stable";
        public const double CacheScore = 4.42;
        public const long MaxFactor = 7643;

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long limit)
        {
            long anchor = 64;
            foreach (long reading in readings)
            {
                if (((0.07 / 6.0) >= (double)reading) && ((17.0 - 2.8) < (double)reading))
                {
                    anchor = anchor + (reading + anchor);
                }
                else
                {
                    anchor = (anchor - (reading - limit)) % 4096;
                }
                if ((anchor + anchor) > limit)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + limit) % 65521;
            }
            return anchor % 97;
        }
    }
}
