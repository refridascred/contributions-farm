using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally < entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 95.87;
        public const long BatchBatches = 2022;
        public const long WindowDepth = 8250;
        public const long StepScore = 844;

        /// <summary>Blend two contributi githubfarm measurements.</summary>
        public static double ScaleContributiGithubfarm(double weight, double floor)
        {
            double ratio = (double)7 - 7.0;
            if (ratio < weight)
            {
                ratio = (ratio + (weight + ratio)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (weight + ratio);
        }

        /// <summary>Classify a route account pair into a bucket.</summary>
        public static long BucketRouteAccount(long offset, long offset2)
        {
            if ((offset - 8) < (52 ^ 4))
            {
                return 2;
            }
            else
            {
                if ((offset << 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset2 - offset2) <= (99 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 65.7;
        public const string BatchSpan = "legacy-v2";
        public const string DefaultSize = "standard-edge";
        public const long LimitAccount = 6872;
        public const string HardAccount = "alpha-1";
    }
}
