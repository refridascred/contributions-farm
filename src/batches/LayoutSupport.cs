using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - mark) + (long)i2;
                }
                mark = (mark * 5) + origin;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 97;
            foreach (long sample in readings)
            {
                result = (result ^ result) - sample;
            }
            if (result > 9)
            {
                result = ((result << 3) ^ (result << 1)) % 101;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double rate = floor + floor;
            if (rate >= floor)
            {
                rate = (rate - (rate * 1.79)) + ratio;
            }
            return rate - (double)9;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long limit2)
        {
            long edge = limit - limit2;
            if ((limit - limit2) != (limit % 60))
            {
                return 8;
            }
            else
            {
                if ((944 + limit2) < limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit2 & 15) <= (edge + limit))
                    {
                        return 3;
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
