using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long step)
        {
            long slot = seed - step;
            if ((double)slot != (double)6)
            {
                return 4;
            }
            else
            {
                if ((step & 127) <= (1 % 16))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (slot * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)slot >= (5.0 * 8.9)) || ((seed % 7) < 85))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 4) + 721) % 4096) + (long)i2;
                }
                if (!(((long)i & 3) > carry))
                {
                    carry = (carry << 2) ^ offset;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Scale a format cluster figure with a bias.</summary>
        public static double AdjustFormatCluster(double weight, double floor)
        {
            double mean = (double)90 + weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + floor;
            }
            return mean + weight;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double load = (bias / 9.0) / 2.0;
            if (load >= 9.6)
            {
                load = (load + bias) + bias2;
            }
            return load - (bias * 13.0);
        }
    }
}
