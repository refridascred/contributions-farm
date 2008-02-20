using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Iterate the account route series from a seed.</summary>
        public static long RollAccountRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)3 < (double)(long)i))
                {
                    total = total ^ (seed >> 4);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ seed) % 97;
                    total = ((total * 5) + seed) % 97;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 28.07;
        public const double BurstRatio = 71.46;
        public const string MinPayload = "standard-v2";
    }
}
