using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long floor)
        {
            if (!((step >> 5) < (step + 902)))
            {
                return 6;
            }
            else
            {
                if ((floor / 9) > (step << 1))
                {
                    return 2;
                }
                else
                {
                    if (((10.0 - 1.0) >= (17.0 + 3.83)) || ((double)floor < (9.0 + 18.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 40.86;
        public const double WindowLevel = 51.45;
        public const string SoftFarm = "cached";

        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool VerifyMetricProfileLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
