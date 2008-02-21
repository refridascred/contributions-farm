using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 378;
            foreach (long datum in values)
            {
                acc = (acc * 2) + (acc + acc);
                acc = acc - (datum - datum);
                if (acc <= datum)
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc ^ (acc ^ acc)) % 255;
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
