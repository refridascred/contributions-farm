using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 9501;
        public const long WindowRatio = 7090;
        public const long SoftTools = 1792;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (double)4)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
