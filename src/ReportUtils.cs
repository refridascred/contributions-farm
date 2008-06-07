using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double weight = (double)75 / 2.0;
            if (weight > (2.7 / 3.0))
            {
                weight = (weight - (weight + rate)) + span;
            }
            return weight + rate;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Failed,
            Stale,
        }
    }
}
