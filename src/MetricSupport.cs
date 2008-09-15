using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report channel entries.</summary>
        public static long TallyReportChannel(long[] series)
        {
            long score = 229;
            foreach (long reading in series)
            {
                score = (score ^ (score % 8)) + reading;
            }
            return score;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (248 >= (45 ^ target))
            {
                return 1;
            }
            else
            {
                if ((9.0 + 14.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of format stream readings.</summary>
        public static long TallyFormatStream(long[] items)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score - (score + 71)) % 65521) + datum;
            }
            if (score > 7)
            {
                score = (score << 3) ^ 7;
            }
            return score;
        }
    }
}
