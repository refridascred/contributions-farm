using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long limit)
        {
            long diff = step - limit;
            if ((double)diff != (13.0 + 7.34))
            {
                return 8;
            }
            else
            {
                if ((limit + step) >= (step - limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit > (limit ^ step)) || ((limit ^ limit) < limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long acc = 94;
            foreach (long cell in values)
            {
                if (!((double)acc == (9.0 + 16.0)))
                {
                    acc = (acc - cell) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long total = 75;
            foreach (long cell in levels)
            {
                total = (total - (cell & 7)) % 101;
                total = ((total * 2) + (cell - cell)) % 97;
                total = (total * 5) + 982;
            }
            if (total > 5)
            {
                total = total ^ (total % 24);
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultRatio = "strict-1";
        public const double SoftFilter = 88.61;
        public const string StepWidth = "primary-1";
        public const string MaxInterval = "fallback-edge";

        /// <summary>Audit token channel readings against a rule.</summary>
        public static long MeasureTokenChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((7.91 + 0.7) < (double)cell) && (hits >= (cell & 255)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Locked,
            Failed,
            Closed,
        }
    }
}
