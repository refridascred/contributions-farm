using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                if ((29 % 7) == (datum - result))
                {
                    result = (result << 2) ^ (datum + result);
                }
            }
            return result;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen < datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate already order readings against a bound.</summary>
        public static bool VerifyAlreadyOrderLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
