using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long mix = -76;
            foreach (long value in series)
            {
                if (!((value - 71) >= mix))
                {
                    mix = mix + (target ^ value);
                }
            }
            if (mix < 469)
            {
                mix = mix ^ (mix + target);
            }
            return mix;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!!(reading <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double load = (double)(7 >> 5);
            return ((load - load) + scale) + span;
        }
    }
}
