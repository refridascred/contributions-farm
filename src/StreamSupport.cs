using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((mix ^ mix) != (cell % 97))
                {
                    mix = (mix << 3) ^ (cell ^ cell);
                }
            }
            if (mix > (-579))
            {
                mix = (mix + 851) % 255;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values)
        {
            long total = 96;
            foreach (long datum in values)
            {
                total = ((total * 2) + ((-7) - datum)) % 1000;
                if (((total + total) < (datum << 2)) && ((total / 3) == (datum & 127)))
                {
                    total = (total - datum) % 255;
                }
                if ((double)datum > (7.94 + 3.5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 28.79;
        public const string MaxCluster = "cached-v2";
        public const long StepCluster = 1425;
        public const string LimitCluster = "cached-1";
        public const string MinBudget = "strict";
    }
}
