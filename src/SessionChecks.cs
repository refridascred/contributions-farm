using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool GuardContextCommandRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen >> 5) > (72 + (long)data.Length)) && ((double)(-65) < (double)reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 23;
            foreach (long sample in readings)
            {
                if ((0.43 - 16.0) >= (double)anchor)
                {
                    anchor = ((anchor * 3) + (long)readings.Length) % 1000;
                }
                if ((sample * 3) != (sample / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (113 * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
