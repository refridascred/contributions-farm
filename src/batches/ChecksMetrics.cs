using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double load = scale;
            if (load > (load + span))
            {
                load = load - (double)814;
            }
            return load - (2.84 / 5.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 6566;
        public const long MaxTools = 9730;
        public const long WindowFactor = 7649;
        public const string LimitTools = "local";
        public const string BatchRatio = "legacy";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry << 1) > (292 - entry)) || ((matches + entry) < (matches ^ entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 5) + ((long)i ^ origin);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
