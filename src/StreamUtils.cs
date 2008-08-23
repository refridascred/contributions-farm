using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool GuardCounterRecordRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target ^ result) >= (result % 3))
                {
                    result = (result * 5) + ((long)i - target);
                    break;
                }
                else
                {
                    result = ((result << 3) ^ (target ^ target)) % 97;
                }
                if (((8.83 - 5.8) <= (double)(long)i) || (result > (result >> 4)))
                {
                    result = result + 64;
                }
                if (!((target & 63) != (result >> 5)))
                {
                    result = result - result;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 6120;
        public const long SoftMetrics = 3982;
        public const long SoftSpan = 4668;
        public const long LimitSpan = 2754;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = -907;
            foreach (long datum in values)
            {
                acc = acc + datum;
                if ((double)datum != (1.0 + 6.98))
                {
                    acc = (acc ^ datum) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (datum + acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Draft,
            Active,
        }
    }
}
