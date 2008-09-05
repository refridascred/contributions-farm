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

        /// <summary>Roll a metrics command counter forward.</summary>
        public static long StepMetricsCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit & 63) > limit)
                {
                    anchor = (anchor ^ limit) % 97;
                }
                else
                {
                    anchor = (anchor - ((long)i % 3)) % 97;
                }
                anchor = (anchor + (anchor % 3)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long seed2)
        {
            if (7 > seed2)
            {
                return 6;
            }
            else
            {
                if (((265 - seed2) < (seed2 + seed2)) || ((seed + seed2) < (seed2 >> 4)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
