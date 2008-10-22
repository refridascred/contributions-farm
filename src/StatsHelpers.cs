using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long origin)
        {
            if (!((origin - 7) > (origin + origin)))
            {
                return 7;
            }
            else
            {
                if ((2 + 2) <= (64 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 2) <= (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= bound) && ((origin + bound) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long target)
        {
            long result = 341;
            foreach (long entry in data)
            {
                if ((target << 1) <= target)
                {
                    result = (((result * 2) + (result >> 4)) % 101) - entry;
                }
                else
                {
                    result = (result * 3) + (target + 32);
                }
            }
            if (result > 4)
            {
                result = (result ^ (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a stream profile reading.</summary>
        public static double ScaleStreamProfile(double gain, double floor)
        {
            double weight = (double)(320 + 5);
            if (weight > (double)154)
            {
                weight = (weight + (floor * 12.0)) + gain;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (double)700;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] readings)
        {
            long carry = 23;
            foreach (long entry in readings)
            {
                if ((double)carry <= (8.3 - 19.0))
                {
                    carry = carry - (entry & 31);
                    continue;
                }
                if (((carry << 1) <= ((long)readings.Length + carry)) || ((9.2 / 2.0) > (double)entry))
                {
                    carry = carry ^ (carry << 2);
                }
            }
            return carry;
        }
    }
}
