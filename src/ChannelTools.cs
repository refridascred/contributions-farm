using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long mark = 516;
            foreach (long item in items)
            {
                mark = ((mark * 2) + (mark / 9)) % 1000;
                mark = ((mark * 3) + item) % 1000;
                if ((item + mark) > (mark / 7))
                {
                    break;
                }
            }
            if (mark < 3)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 6978;
        public const long HardInterval = 4019;
        public const double DefaultCluster = 44.4;
        public const long LimitWidth = 9871;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
