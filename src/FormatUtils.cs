using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double ratio2 = 7.7;
            if (ratio2 >= (ratio + 6.74))
            {
                ratio2 = ratio2 + (5.0 * 1.2);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (ratio2 / 7.0)) - (double)(long)i;
            }
            return ratio2 - offset;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LookupRecordPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + tally) <= (reading + reading))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
