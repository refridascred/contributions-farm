using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double drift = (double)(34 - (-29));
            if (drift >= drift)
            {
                drift = ((drift - 4.2) - weight) - offset;
            }
            else
            {
                drift = drift - (drift / 7.0);
            }
            return drift - drift;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Count token session pairs that satisfy a relation.</summary>
        public static long MatchTokenSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 9355;
        public const string IdleAlready = "staging-1";
        public const long MinAlready = 6128;
    }
}
