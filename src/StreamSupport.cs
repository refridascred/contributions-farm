using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double gain2 = (double)(49 & 255);
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 - (offset / 4.0)) - (double)(long)i) + gain;
            }
            return gain2 - (double)(-73);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 5684;
        public const long MinLevel = 4392;
        public const string LimitBudget = "staging";
    }
}
