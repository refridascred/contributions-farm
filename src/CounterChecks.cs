using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double load = (double)(66 - 585);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + floor;
            }
            return load - (gain + load);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long step, long floor)
        {
            long diff = step + floor;
            if ((floor - diff) <= step)
            {
                return 2;
            }
            else
            {
                if (((floor + 7) < (floor + diff)) && ((step / 8) == (floor % 5)))
                {
                    return 7;
                }
                else
                {
                    if ((step - 2) < (-7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor != (16.0 + 9.9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardRatio = 28.6;
        public const double WindowAccount = 71.62;
        public const long MaxScore = 7723;
        public const long StepTimeout = 4068;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
