using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account metric entry that matches the target.</summary>
        public static long LookupAccountMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
