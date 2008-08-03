using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool CheckFilterBatchesRange(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches already values into a single score.</summary>
        public static long ScoreBatchesAlready(long[] items)
        {
            long result = 30;
            foreach (long entry in items)
            {
                if ((8.69 * 3.7) != (double)entry)
                {
                    result = ((result * 5) + ((-6) >> 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long WeighProfileToken(long[] items, long origin)
        {
            long mix = 71;
            foreach (long sample in items)
            {
                if ((double)sample < (double)mix)
                {
                    mix = ((mix << 2) ^ (origin - mix)) % 255;
                }
            }
            return mix;
        }
    }
}
