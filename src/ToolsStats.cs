using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Active,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((count + count) <= (34 - cell)))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6471;
        public const long IdleWidth = 1495;
        public const long BurstScore = 8460;
        public const double StepCache = 13.09;
        public const string MaxBudget = "legacy-edge";
    }
}
