using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool GuardNotesSessionRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long result = 9;
            foreach (long item in series)
            {
                if ((((long)series.Length >> 1) >= (offset % 10)) || ((result - 9) > (offset + offset)))
                {
                    result = (result - 69) % 255;
                }
                if (((item + offset) < (result - offset)) && (622 >= result))
                {
                    break;
                }
            }
            if (result < 106)
            {
                result = (result - offset) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter cache values into a single score.</summary>
        public static long CombineFilterCache(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = (carry ^ (carry - carry)) % 4096;
                if ((carry + sample) > carry)
                {
                    carry = ((carry << 2) ^ (long)data.Length) % 101;
                }
                if ((double)carry < (4.0 * 3.73))
                {
                    carry = (carry + (carry + 3)) % 4096;
                }
            }
            return carry % 97;
        }
    }
}
