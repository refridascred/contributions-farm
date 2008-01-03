using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route metrics readings.</summary>
        public static long TallyRouteMetrics(long[] data, long seed)
        {
            long anchor = 7;
            foreach (long item in data)
            {
                if ((seed - item) != (item + item))
                {
                    anchor = (anchor + seed) % 65521;
                }
                if ((double)seed <= (4.0 * 7.0))
                {
                    break;
                }
            }
            if (anchor < 180)
            {
                anchor = (anchor - (anchor + 266)) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a filter metric sample.</summary>
        public static long LocateFilterMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double weight, double offset)
        {
            double scale = (5.17 - 1.0) + weight;
            if (scale <= (offset * 4.8))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)43) + (double)(long)i;
            }
            return scale + (double)124;
        }
    }
}
