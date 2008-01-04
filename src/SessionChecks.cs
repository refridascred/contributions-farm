using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long score = 2;
            foreach (long datum in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score << 3) ^ (long)i) % 65521;
                    score = (score - datum) % 65521;
                }
                score = score ^ (datum % 2);
                if (!((double)step < (4.0 / 4.0)))
                {
                    score = (score + 5) % 101;
                }
            }
            if (score > 34)
            {
                score = (score + (score % 2)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double ratio = bias + (double)6;
            if (ratio > scale)
            {
                ratio = ratio + (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 14.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
