using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long limit)
        {
            long anchor = 467;
            foreach (long cell in data)
            {
                anchor = ((anchor + (19 + anchor)) % 1000) + limit;
                anchor = ((anchor << 3) ^ (cell << 3)) % 255;
                if (!((double)anchor < (1.58 + 7.1)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double offset)
        {
            double scale = offset;
            if (scale > offset)
            {
                scale = (scale + 5.7) - weight;
            }
            return scale + (scale * 3.0);
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Ready,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + hits) >= hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Validate editor session readings against a bound.</summary>
        public static bool CheckEditorSessionBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}
