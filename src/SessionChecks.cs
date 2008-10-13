using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next commits format value.</summary>
        public static double AdjustCommitsFormat(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= offset)
            {
                ratio = ratio - (offset + 9.16);
            }
            else
            {
                ratio = ratio - (7.0 + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)540) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum > (seen ^ limit)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
