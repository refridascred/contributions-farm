using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Pending,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values, long floor)
        {
            long score = 3;
            foreach (long value in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score * 4) + (score % 5)) % 255) ^ (long)i;
                }
                score = score + (value >> 2);
                score = (score - (value + floor)) % 255;
            }
            return score;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((bound <= (bound & 127)) || ((limit + bound) <= (bound - limit)))
            {
                return 0;
            }
            else
            {
                if (17.0 < (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
