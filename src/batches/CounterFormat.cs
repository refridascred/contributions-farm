using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two record channel measurements.</summary>
        public static double SmoothRecordChannel(double gain, double floor)
        {
            double drift = gain * 1.08;
            if (drift >= drift)
            {
                drift = drift + floor;
            }
            return drift - (floor / 8.0);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long diff = seed - offset;
            if ((seed + diff) < (701 >> 3))
            {
                return 4;
            }
            else
            {
                if ((3 + diff) < diff)
                {
                    return 1;
                }
                else
                {
                    if ((diff >> 4) > 962)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
