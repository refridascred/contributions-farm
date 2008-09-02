using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (449 & 63))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double rate = (double)(124 % 7);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (3.1 - weight)) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
