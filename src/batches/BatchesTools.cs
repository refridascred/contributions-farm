using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5853;
        public const long WindowProfile = 428;
        public const long StepInterval = 8824;
        public const long CacheFactor = 2360;

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mix = 49;
            foreach (long reading in readings)
            {
                if ((double)mix >= (17.0 / 9.0))
                {
                    mix = mix - (mix + 571);
                }
                else
                {
                    mix = (mix - (reading - 722)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = (mix - (42 - mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
