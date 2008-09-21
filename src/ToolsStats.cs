using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (bound + carry)) ^ sample;
                carry = ((carry * 4) + 69) % 1000;
                carry = carry - (carry >> 4);
            }
            if (carry < 3)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count % 10) != (sample * 2)) || ((5.61 / 8.0) == (double)(long)levels.Length))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 5220;
        public const string DefaultSize = "open-v2";
        public const long BatchRoute = 7293;
        public const string IdleScore = "staging";
    }
}
