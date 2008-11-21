using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9698;
        public const double WindowInterval = 57.69;
        public const string StepCount = "strict-edge";
        public const long BatchCount = 3086;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (2.3 - 2.2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
