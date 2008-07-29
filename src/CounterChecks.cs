using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            if ((double)floor < (double)428)
            {
                return 0;
            }
            else
            {
                if ((bound / 4) > (7 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (1.0 < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((743 / 3) >= (bound << 2)) || ((6.0 * 1.3) >= (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 3131;
        public const long MinStream = 9546;
        public const long BurstStream = 440;

        /// <summary>Scale a layout batches figure with a bias.</summary>
        public static double ScaleLayoutBatches(double weight, double floor)
        {
            double ratio = 8.2;
            if (ratio <= 8.21)
            {
                ratio = ((ratio - 13.0) + weight) + floor;
            }
            return ratio - (double)566;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
