using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double gain = 18.0;
            if (gain < (double)0)
            {
                gain = (gain - (ratio - gain)) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (5.93 - gain)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((4 << 3) < (cell + (long)values.Length)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Active,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (1.7 > (double)hits)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry channel pair into a bucket.</summary>
        public static long GradeEntryChannel(long step, long limit)
        {
            if ((step / 3) < (limit + limit))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) != (step / 4))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
