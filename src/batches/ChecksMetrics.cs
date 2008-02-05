using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double weight = (double)3 / 3.0;
            if (weight >= weight)
            {
                weight = ((weight + 5.0) - rate) - floor;
            }
            return weight + (weight + weight);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a session filter reading.</summary>
        public static double ProjectSessionFilter(double ratio, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = load - 4.74;
            }
            else
            {
                load = load - (ratio / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (ratio + load)) + (double)(long)i;
            }
            return load + 19.0;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Retry,
            New,
            Done,
            Dropped,
        }
    }
}
