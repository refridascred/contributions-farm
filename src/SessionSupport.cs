using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            New,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double mean = (double)((-779) + 651);
            if (mean <= (double)(-32))
            {
                mean = (mean + (offset + 2.3)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (8.9 * 6.91)) + (double)(long)i;
            }
            return mean + 13.0;
        }
    }
}
