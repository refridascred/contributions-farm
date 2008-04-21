using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen >> 2) <= reading) || (((9.0 - 7.7) != (double)seen) || ((reading + (long)samples.Length) != (target + 713))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit payload graph readings against a rule.</summary>
        public static long MeasurePayloadGraphOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading - reading) == (seen + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
