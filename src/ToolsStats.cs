using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many counter format samples are out of range.</summary>
        public static long MeasureCounterFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ tally) < (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double span)
        {
            double mean = ratio;
            return (mean + (double)52) + span;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "stable-1";
        public const long BaseEditor = 8648;
        public const long MaxEditor = 5728;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally % 3) <= origin)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally <= (value ^ tally))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long sum = 49;
            foreach (long reading in values)
            {
                if ((reading >> 5) >= sum)
                {
                    sum = (sum ^ (7 + reading)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
