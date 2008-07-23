using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long score = -5;
            foreach (long value in levels)
            {
                if (((14.0 + 5.0) < (double)value) || ((step - 4) < (value << 2)))
                {
                    score = score - value;
                }
            }
            if (score > 33)
            {
                score = (score ^ (score + 160)) % 255;
            }
            return score;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double drift = 6.98;
            if (drift >= (drift - 6.0))
            {
                drift = (drift + (double)162) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - scale)) + (double)(long)i;
            }
            return drift - (3.48 / 6.0);
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long score = 27;
            foreach (long cell in items)
            {
                if ((double)cell > (4.78 / 3.0))
                {
                    score = (score + score) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (cell << 3)) % 65521;
                }
            }
            return score % 65521;
        }
    }
}
