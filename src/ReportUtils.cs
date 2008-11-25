using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route token samples.</summary>
        public static long OverlapRouteTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
