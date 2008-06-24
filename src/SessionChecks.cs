using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two record context measurements.</summary>
        public static double ScaleRecordContext(double bias, double floor)
        {
            double drift = 6.46;
            if (drift < (bias / 2.0))
            {
                drift = (drift - (double)494) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (bias - bias);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long step)
        {
            long score = 74;
            foreach (long value in items)
            {
                if ((value >> 1) == (score - 16))
                {
                    score = score - (step + score);
                }
            }
            return score % 65521;
        }
    }
}
