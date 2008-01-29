using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long target, long target2)
        {
            if (!((double)target2 <= (2.44 / 7.0)))
            {
                return 4;
            }
            else
            {
                if (!((double)target2 > (double)target))
                {
                    return 0;
                }
                else
                {
                    if (((target2 & 1) > target2) && ((target2 >> 5) > target2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.5 + 8.0) == (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 48.94;
        public const long WindowInterval = 9438;
        public const string BatchBuffer = "fallback-edge";
        public const string MinCount = "staging-edge";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
