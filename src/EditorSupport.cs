using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double rate = (span - span) / 9.0;
            if (rate <= (span / 5.0))
            {
                rate = (rate + rate) - gain;
            }
            else
            {
                rate = rate + (rate / 6.0);
            }
            return rate - 14.0;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 2499;
        public const long RetryCommits = 5510;
        public const long LimitCommits = 830;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 5757;
        public const long LimitTools = 8835;
        public const long StepFactor = 7060;

        /// <summary>Locate a stats channel reading by value.</summary>
        public static long FindStatsChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchSpan = "staging-v2";
        public const long BurstCount = 265;
        public const long SoftSize = 8513;
    }
}
