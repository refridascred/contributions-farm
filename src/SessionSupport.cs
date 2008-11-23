using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up format queue samples.</summary>
        public static long MatchFormatQueueCount(long[] samples)
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

        /// <summary>Blend two stats githubfarm measurements.</summary>
        public static double ProjectStatsGithubfarm(double bias, double offset)
        {
            double mean = (double)(43 << 3);
            if (mean <= (offset + 6.94))
            {
                mean = (mean + 6.0) + bias;
            }
            return mean + (double)491;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
