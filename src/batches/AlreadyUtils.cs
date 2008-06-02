using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step != (double)(long)i)
                {
                    state = (state << 3) ^ (50 >> 4);
                    break;
                }
                else
                {
                    state = ((state * 3) + (state + step)) % 65521;
                    state = state ^ step;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double load = 9.4;
            if (load >= ratio)
            {
                load = (load - (ratio - load)) - floor;
            }
            return load - ratio;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
