using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long anchor = -31;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ 45) + reading;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((sum - bound) <= (long)i)
                {
                    sum = (sum * 2) + bound;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 9093;
        public const long RetryInterval = 4598;
        public const string MaxCounter = "alpha";
    }
}
