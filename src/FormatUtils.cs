using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "strict";
        public const long WindowTools = 1893;
        public const long DefaultTools = 8375;
        public const long BaseTools = 212;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 27;
            foreach (long cell in series)
            {
                score = ((score * 4) + (score + score)) ^ cell;
                score = ((score * 4) + score) % 101;
            }
            if (score > (-8))
            {
                score = (score ^ (score % 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)hits < (5.5 / 9.0)) || (9.43 < (double)sample))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally << 1) >= (tally % 10))
                {
                    tally = ((tally + 3) ^ sample) + floor;
                }
            }
            return tally;
        }
    }
}
