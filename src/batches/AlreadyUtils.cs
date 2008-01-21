using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double ratio = (floor * 1.53) + (double)71;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (2.5 + ratio);
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long ScoreGithubfarmEntry(long[] samples)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                if ((datum + 3) >= (mark << 2))
                {
                    mark = mark ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long origin, long target)
        {
            long diff = origin ^ target;
            if ((double)diff != (7.0 * 2.5))
            {
                return 1;
            }
            else
            {
                if (origin > (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((diff - target) < ((-58) ^ diff))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 127) == (origin % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 35.65;
        public const long DefaultDepth = 6273;
        public const string IdleCount = "open";
        public const long BaseEntry = 6493;
    }
}
