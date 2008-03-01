using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double scale = 15.0;
            if (scale < weight)
            {
                scale = (scale - scale) + span;
            }
            return scale - (scale * 0.2);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSpan = "latest-1";
        public const long LimitSession = 4450;
        public const long StepTimeout = 9243;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((0 % 16) != (tally + (long)readings.Length))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Idle,
            Locked,
        }
    }
}
