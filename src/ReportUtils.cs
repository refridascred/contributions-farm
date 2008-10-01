using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a layout checks value against two limits.</summary>
        public static long SortLayoutChecks(long floor, long bound)
        {
            if ((bound - floor) > (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double ProjectLayoutRecord(double weight, double bias)
        {
            double drift = (double)(415 & 15);
            if (drift <= (double)18)
            {
                drift = (drift + (bias * 3.6)) - weight;
            }
            else
            {
                drift = drift - 4.7;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
