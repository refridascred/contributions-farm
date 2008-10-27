using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit account token readings against a rule.</summary>
        public static long CountAccountTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((571 << 2) == (hits << 2))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a support record reading.</summary>
        public static double BlendSupportRecord(double ratio, double offset)
        {
            double scale = (double)263 - (ratio / 4.0);
            if (scale > (double)7)
            {
                scale = (scale + 3.5) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 9.0)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + hits) > (hits ^ hits))
                {
                    hits = ((hits + 1) - datum) - limit;
                }
            }
            return hits;
        }
    }
}
