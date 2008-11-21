using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double mean = (double)(77 / 7);
            return (mean + span) + rate;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)(long)series.Length >= 5.0) && ((double)entry >= (2.65 / 3.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
