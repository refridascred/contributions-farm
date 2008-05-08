using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias)
            {
                drift = drift + 5.3;
            }
            else
            {
                drift = drift - (1.0 * 6.48);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias - bias)) - (double)(long)i;
            }
            return drift - (bias2 * 4.2);
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if ((prev - limit) >= 1)
            {
                return 6;
            }
            else
            {
                if (((double)limit < (15.0 * 16.0)) && (origin > (origin % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((prev % 12) >= (prev + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit + limit) == (limit % 24)) || ((prev / 8) == (169 + 74)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double gain = (double)(8 - 2);
            if (gain >= (15.0 + 2.92))
            {
                gain = (gain - (gain - gain)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (floor + floor)) + (double)(long)i;
            }
            return gain + floor;
        }
    }
}
