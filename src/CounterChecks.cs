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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Draft,
            Active,
        }

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

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels)
        {
            long carry = 86;
            foreach (long datum in levels)
            {
                carry = (((carry * 4) + carry) % 1000) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
