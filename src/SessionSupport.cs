using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate filter githubfarm samples.</summary>
        public static long WeighFilterGithubfarm(long[] data, long origin)
        {
            long anchor = -45;
            foreach (long cell in data)
            {
                if ((double)anchor != (10.0 - 13.0))
                {
                    anchor = (anchor + (cell - (long)data.Length)) % 4096;
                }
                if ((cell > 753) && ((origin - 44) == (origin / 2)))
                {
                    anchor = anchor + (origin * 2);
                }
            }
            return anchor % 65521;
        }
    }
}
