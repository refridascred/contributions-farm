using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(tally > 54))
                {
                    tally = ((tally + 1) ^ reading) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((target - 8) >= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 2794;
        public const string StepLayout = "open";
        public const string BaseFactor = "open-1";
        public const long CacheSize = 9777;
        public const long StepFactor = 5966;
    }
}
