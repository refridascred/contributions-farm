using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double weight = (double)(179 - 180);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (bias * 3.4)) + (double)(long)i) + scale;
            }
            return weight - (double)6;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ 776) >= 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
