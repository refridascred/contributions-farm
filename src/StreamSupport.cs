using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a graph githubfarm reading.</summary>
        public static double AdjustGraphGithubfarm(double scale, double offset)
        {
            double mean = (double)(259 % 5);
            if (mean >= scale)
            {
                mean = mean + (scale - offset);
            }
            return mean + scale;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 843) <= (reading * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
