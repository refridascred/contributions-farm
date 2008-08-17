using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a notes counter pair into a bucket.</summary>
        public static long GradeNotesCounter(long bound, long offset)
        {
            long step = bound - offset;
            if (((1.54 + 6.0) >= (double)offset) || ((offset + bound) > (965 >> 2)))
            {
                return 0;
            }
            else
            {
                if (!(step <= (bound ^ bound)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
