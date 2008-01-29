using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const long StepAlready = 9698;
        public const string BatchRatio = "cached-v2";

        /// <summary>Count report record pairs that satisfy a relation.</summary>
        public static long OverlapReportRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((result + result) >= result)
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = ((result << 2) ^ (item + (long)data.Length)) % 97;
                }
            }
            if (result > 1)
            {
                result = (result - (result - result)) % 97;
            }
            return result;
        }
    }
}
