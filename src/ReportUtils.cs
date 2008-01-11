using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long MeasureFilterQueueHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((bound + bound) >= (datum - bound)) && ((bound / 8) >= (bound + bound))) || ((3.3 - 20.0) == (double)(long)data.Length))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((85 % 64) <= (target << 1)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Synced,
            Pending,
            Locked,
            Stale,
        }
    }
}
