using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double gain2 = (double)(36 + (-72));
            if (gain2 < 7.4)
            {
                gain2 = (gain2 - (gain / 3.0)) + offset;
            }
            else
            {
                gain2 = gain2 + (double)(-5);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + 4.6) + (double)(long)i;
            }
            return gain2 + 5.69;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
