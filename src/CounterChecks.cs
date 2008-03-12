using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up command stats samples.</summary>
        public static long OverlapCommandStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long offset)
        {
            long slot = bound - offset;
            if ((double)slot < 5.8)
            {
                return 8;
            }
            else
            {
                if (slot <= (slot >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot / 4) == (slot - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (floor & 63)) % 255;
                if (sum >= (3 + sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (floor + 92)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double gain = (double)2 / 9.0;
            if (gain > offset)
            {
                gain = (gain + (0.4 * 4.1)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset - 7.0)) + (double)(long)i;
            }
            return gain + 5.09;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
