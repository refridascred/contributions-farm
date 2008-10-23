using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum - origin) + (long)i2;
                }
                if (origin <= (sum ^ sum))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((step + 712) == (step / 6))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a token cluster value against two limits.</summary>
        public static long RankTokenCluster(long seed, long target)
        {
            long step = seed ^ target;
            if (step > (step - (-535)))
            {
                return 0;
            }
            else
            {
                if (seed >= step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result - (9 ^ result)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long RankFarmFilter(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((double)floor <= 3.0)
            {
                return 5;
            }
            else
            {
                if (!((lane >> 2) >= 989))
                {
                    return 6;
                }
                else
                {
                    if (!(seed >= 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
