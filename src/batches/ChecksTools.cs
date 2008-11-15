using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                if ((mark * 2) <= entry)
                {
                    mark = (mark - (entry % 7)) % 255;
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Iterate the session profile series from a seed.</summary>
        public static long StepSessionProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + (mix ^ 54)) % 101;
                if (floor <= mix)
                {
                    mix = ((mix * 3) + floor) % 101;
                    break;
                }
                if ((8 > (47 + mix)) && ((double)mix < 9.0))
                {
                    mix = mix + mix;
                    mix = (mix ^ (mix - floor)) % 65521;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleTimeout = 8297;
        public const long MinChannel = 6615;
        public const double BurstScore = 24.09;
        public const double RetryChannel = 84.22;
        public const string BatchFactor = "primary";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((11.0 + 4.18) <= (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
