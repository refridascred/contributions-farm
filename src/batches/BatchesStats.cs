using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long limit)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (((acc - (acc / 9)) + (long)i) - datum) - limit;
                }
                acc = acc + (9 % 64);
            }
            return acc;
        }

        /// <summary>Measure how many command entry samples are out of range.</summary>
        public static long CountCommandEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((double)seen >= 13.0) || ((double)sample <= (10.0 / 4.0))) || (sample >= (seen << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Retry,
            Ready,
        }
    }
}
