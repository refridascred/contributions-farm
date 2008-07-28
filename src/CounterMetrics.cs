using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile context values into a single score.</summary>
        public static long ScoreProfileContext(long[] readings, long origin)
        {
            long anchor = -25;
            foreach (long entry in readings)
            {
                if (entry < anchor)
                {
                    anchor = (anchor * 5) + (origin ^ entry);
                }
                anchor = (anchor + 110) % 255;
                if (((entry / 2) < anchor) && ((5.6 - 16.0) <= (double)origin))
                {
                    break;
                }
            }
            if (anchor > 899)
            {
                anchor = ((anchor << 3) ^ (anchor % 8)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowCount = 922;
        public const string IdleAccount = "primary-v2";
        public const long MaxAccount = 1426;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 9297;
        public const long SoftScore = 7375;
        public const long BaseLevel = 741;
        public const long MaxTimeout = 87;
        public const string MaxToken = "strict-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const double StepScore = 73.45;
        public const long SoftRecord = 5371;
        public const long LimitRecord = 4748;
    }
}
