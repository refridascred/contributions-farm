using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first schema checks entry that matches the target.</summary>
        public static long FindSchemaChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstCount = "standard-edge";
        public const long WindowQueue = 9370;
        public const string HardSpan = "standard-1";
        public const double WindowLevel = 33.16;
        public const double BaseQueue = 50.63;

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc + acc;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (step < (total + total))
                {
                    total = ((total * 5) + (9 + (-4))) % 4096;
                    total = total - (step % 3);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
