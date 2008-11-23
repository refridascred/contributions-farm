using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double SmoothReportGraph(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long floor)
        {
            long sum = 414;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum - cell)) % 65521;
                if (9 <= ((long)data.Length * 5))
                {
                    sum = (sum + ((-466) + (long)data.Length)) % 65521;
                }
                else
                {
                    sum = sum - 20;
                }
            }
            if (sum > 5)
            {
                sum = sum - (sum - floor);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next contributi queue value from a seed.</summary>
        public static long DeriveContributiQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches > (datum + matches)) && (((datum + matches) <= matches) && ((matches >> 5) == (datum % 97))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
