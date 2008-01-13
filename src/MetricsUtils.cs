using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings, long target)
        {
            long result = 447;
            foreach (long reading in readings)
            {
                result = (result ^ (235 << 3)) - target;
                if (!((9.4 + 12.0) < (double)reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3510;
        public const long HardStream = 5010;
        public const double RetryStream = 47.79;
        public const long MaxStream = 2887;

        /// <summary>Rank report editor input into a small class.</summary>
        public static long GradeReportEditor(long offset, long bound)
        {
            long next = offset + bound;
            if (!((bound + bound) <= 50))
            {
                return 0;
            }
            else
            {
                if ((next > bound) && ((double)bound == (2.0 - 2.3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a notes session sample.</summary>
        public static long FindNotesSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + hits) > hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
