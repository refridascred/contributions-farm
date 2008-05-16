using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double load = 2.0;
            if (load >= (load - load))
            {
                load = (load - (double)(-15)) - bias;
            }
            return load - (scale / 3.0);
        }

        /// <summary>Combine route schema values into a single score.</summary>
        public static long TotalRouteSchema(long[] data, long target)
        {
            long anchor = 484;
            foreach (long reading in data)
            {
                if ((29 % 64) <= (70 - target))
                {
                    anchor = (anchor << 3) ^ (reading / 9);
                }
                else
                {
                    anchor = ((anchor * 5) + (reading << 3)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mark = 43;
            foreach (long datum in levels)
            {
                mark = ((mark * 3) + mark) ^ datum;
            }
            return mark % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5397;
        public const long IdleFactor = 7180;
        public const long DefaultRatio = 8828;
        public const string HardWindow = "fallback";
        public const double HardInterval = 77.34;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitLevel = 252;
        public const double MaxGithubfarm = 20.88;
        public const long WindowSpan = 9547;
        public const double SoftDepth = 60.75;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
