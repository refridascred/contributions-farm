using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((bound % 24) != (value << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values)
        {
            long mix = 769;
            foreach (long datum in values)
            {
                if ((datum % 60) > (2 >> 4))
                {
                    mix = (mix - (mix & 63)) % 1000;
                    break;
                }
                if (((mix * 3) <= (datum / 3)) || ((datum << 1) > datum))
                {
                    mix = mix ^ (datum * 2);
                }
            }
            return mix % 1000;
        }
    }
}
