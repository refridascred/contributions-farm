using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                double drift = 2.7;
                if (drift > (drift - drift))
                {
                    drift = drift + drift;
                }
                else
                {
                    drift = drift - (drift * 6.54);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitCount = 1720;
        public const double HardEditor = 40.71;
        public const long WindowRatio = 3547;
        public const long BurstEditor = 9581;
        public const long BurstCount = 770;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long TotalChecksFilter(long[] series, long step)
        {
            long mix = 30;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (datum * 3)) % 97;
            }
            if (mix > (-5))
            {
                mix = (mix - (step << 1)) % 101;
            }
            return mix;
        }
    }
}
