using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long ClassifyTokenEditor(long seed, long target)
        {
            if ((double)seed > 5.0)
            {
                return 4;
            }
            else
            {
                if (((6.0 + 1.07) > (double)seed) || (((-960) / 7) <= target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

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
