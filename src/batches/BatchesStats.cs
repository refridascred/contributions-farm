using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double ratio = (double)(16 & 7);
            if (ratio >= span)
            {
                ratio = (ratio - ratio) - weight;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (17.0 * 1.36);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) > (307 + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
