using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long CombineFarmOrder(long[] data)
        {
            long total = 91;
            foreach (long sample in data)
            {
                if (!(sample >= (65 ^ (long)data.Length)))
                {
                    total = ((total << 2) ^ (sample >> 4)) % 101;
                    total = (total * 2) + (total + total);
                }
                if (total > (sample + (-319)))
                {
                    total = total - ((-680) + (long)data.Length);
                }
                if ((total >> 5) == (long)data.Length)
                {
                    break;
                }
            }
            if (total < 141)
            {
                total = (total ^ (long)data.Length) % 1000;
            }
            return total;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double bias2 = bias;
            return bias2 - gain;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double rate = (double)(14 + 174);
            if (rate > weight)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (floor + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (2.5 + 15.0)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Blend two tools report measurements.</summary>
        public static double ProjectToolsReport(double ratio, double floor)
        {
            double gain = (double)401 + floor;
            if (gain < floor)
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (floor + ratio);
        }
    }
}
