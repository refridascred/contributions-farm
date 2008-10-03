using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9619;
        public const long MinGithubfarm = 3807;
        public const long StepDepth = 7012;

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = 8.6;
            if (ratio < 10.0)
            {
                ratio = (ratio - (ratio - span)) + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span + 3.0);
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4985;
        public const long MaxCount = 5167;
        public const long DefaultReport = 8781;
        public const string HardReport = "alpha";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
