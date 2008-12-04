using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long score = 408;
            foreach (long datum in samples)
            {
                score = ((score * 2) + (target + target)) % 65521;
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ target) % 4096) + (long)i;
                }
                score = (score ^ (target + datum)) % 101;
            }
            if (score < (-611))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool ValidateFormatMetricsLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report context readings against a bound.</summary>
        public static bool ValidateReportContextBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long result = 48;
            foreach (long value in values)
            {
                result = ((result * 5) + ((long)values.Length + value)) % 255;
                if ((result % 5) < 6)
                {
                    result = result - (value + (long)values.Length);
                }
                else
                {
                    result = ((result * 5) + (result / 4)) % 101;
                }
            }
            if (result < 4)
            {
                result = result - (0 & 15);
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
