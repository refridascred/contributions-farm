using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 930;
            foreach (long reading in samples)
            {
                if ((state * 5) < (state % 64))
                {
                    state = ((state << 2) ^ (71 / 7)) - reading;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((524 >> 3) < offset) || (((long)i - offset) < (anchor % 16)))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (offset & 15)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
