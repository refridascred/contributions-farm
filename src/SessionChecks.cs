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

        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long ScoreContributiTools(long[] samples, long bound)
        {
            long mix = 6;
            foreach (long reading in samples)
            {
                if (!(reading < (5 - reading)))
                {
                    mix = ((mix * 4) + (bound >> 3)) % 255;
                }
                mix = (mix << 2) ^ (bound & 3);
            }
            return mix % 65521;
        }
    }
}
