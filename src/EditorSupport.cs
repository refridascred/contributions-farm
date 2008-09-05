using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double load = 3.93;
            return ((load + load) + rate) + offset;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((7 - 22) != (mark / 9)))
                {
                    mark = (mark * 5) + (mark + limit);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long bound, long offset)
        {
            if ((offset + 86) <= bound)
            {
                return 2;
            }
            else
            {
                if ((bound + offset) >= (bound >> 4))
                {
                    return 5;
                }
                else
                {
                    if (offset < (offset << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (reading / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Active,
            Paused,
        }
    }
}
