using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Stale,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two report record measurements.</summary>
        public static double ProjectReportRecord(double scale, double bias)
        {
            double weight = (double)(35 ^ 76);
            if (weight > scale)
            {
                weight = weight + (scale - scale);
            }
            else
            {
                weight = weight - (double)385;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (10.0 * 2.7)) - (double)(long)i;
            }
            return weight + bias;
        }
    }
}
