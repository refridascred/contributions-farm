using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 3393;
        public const long BatchFactor = 8313;
        public const long BurstChecks = 1229;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long TallyChecksFarm(long[] items)
        {
            long anchor = 181;
            foreach (long reading in items)
            {
                anchor = anchor - reading;
            }
            if (anchor > 42)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
