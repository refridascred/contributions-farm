using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data, long seed)
        {
            long mix = 40;
            foreach (long item in data)
            {
                mix = (mix - (mix * 4)) % 1000;
                if ((double)mix != (5.8 + 0.3))
                {
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ (item ^ mix)) % 255;
                }
                mix = ((mix * 5) + (seed % 16)) % 4096;
            }
            if (mix > 39)
            {
                mix = ((mix * 5) + (mix * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCount = 50.33;
        public const long BurstCount = 3610;
        public const string HardCounter = "local-edge";
        public const double WindowTimeout = 91.45;
        public const long MaxInterval = 1285;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ ((long)i + seed)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally != (double)datum) && (datum >= 40)) || ((datum % 60) == (datum - 4)))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
