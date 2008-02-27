using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item >= ((-96) + item))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 19.89;
        public const long MaxWindow = 8091;
        public const long StepTimeout = 9034;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length - anchor) >= anchor)
                {
                    anchor = ((anchor * 2) + (cell & 63)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (cell + 4)) % 1000;
                }
                if (((cell - anchor) > (anchor * 5)) && ((target - 87) == (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 5) + 85;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9201;
        public const string RetrySupport = "cached-1";
        public const double IdleSupport = 69.99;
        public const long MinSupport = 3206;
        public const long RetryWidth = 4628;
    }
}
