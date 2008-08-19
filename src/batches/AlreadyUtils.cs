using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 25.04;
        public const string RetryToken = "strict-v2";
        public const long WindowToken = 3816;
        public const double MaxRatio = 89.38;
        public const long IdleLevel = 7678;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Stale,
            Draft,
            Ready,
        }
    }
}
