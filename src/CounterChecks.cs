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

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Locked,
            Pending,
        }
    }
}
