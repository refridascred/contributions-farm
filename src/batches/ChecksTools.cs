using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2687;
        public const long WindowEntry = 5504;
        public const long IdleScore = 7233;

        /// <summary>Audit batch report readings against a rule.</summary>
        public static long CountBatchReportMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample != (7.0 * 1.4)) && ((double)count > (7.9 - 1.3)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples)
        {
            long score = 23;
            foreach (long item in samples)
            {
                if ((score & 127) < (score / 2))
                {
                    score = (score * 3) + (score * 2);
                }
                else
                {
                    score = (score + (item * 3)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
