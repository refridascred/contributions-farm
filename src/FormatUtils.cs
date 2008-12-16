using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long AuditEntryMetricMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + bound) > (datum ^ bound))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long origin, long step)
        {
            if (!((double)origin >= 7.3))
            {
                return 4;
            }
            else
            {
                if ((192 - origin) >= (step / 8))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 59.17;
        public const long DefaultFactor = 1757;
        public const double IdleSize = 18.82;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 3662;
        public const long SoftOrder = 7764;
        public const long BatchInterval = 148;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long state = 73;
            foreach (long datum in readings)
            {
                state = state + (datum & 255);
            }
            if (state < 774)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }
    }
}
