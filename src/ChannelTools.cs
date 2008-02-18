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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] values, long bound)
        {
            long state = 0;
            foreach (long reading in values)
            {
                if (7.1 > (double)state)
                {
                    state = (((state * 2) + (state >> 4)) + reading) + bound;
                }
            }
            return state;
        }
    }
}
