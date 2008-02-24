using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 4947;
        public const long CacheStats = 3152;
        public const string BaseSpan = "latest-v2";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step == (5.12 / 5.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long CountAccountContextMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((991 >> 4) < (sample + 2))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((776 / 4) > sample) && (7 < (96 - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream route sample.</summary>
        public static long SeekStreamRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
