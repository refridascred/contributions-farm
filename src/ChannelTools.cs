using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxWidth = "latest";
        public const long LimitBudget = 1860;
        public const double BatchChannel = 81.28;
        public const long MinChannel = 1721;
        public const long StepChannel = 7602;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            if ((6 & 7) > (limit << 1))
            {
                return 2;
            }
            else
            {
                if (7.48 <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
