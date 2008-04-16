using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7262;
        public const string StepSupport = "primary-v2";
        public const long IdleSupport = 4785;

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double weight = (double)(760 ^ 898);
            if (weight < weight)
            {
                weight = (weight - (bias / 4.0)) - bias2;
            }
            return weight - (weight * 7.95);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
