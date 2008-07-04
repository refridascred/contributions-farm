using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next notes already value from a seed.</summary>
        public static long RollNotesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (floor + 431)) % 1000;
                score = ((score << 3) ^ score) % 4096;
                score = (score ^ (long)i) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double gain2 = offset;
            return (gain2 + (gain2 - gain2)) + gain;
        }

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool VerifyFilterSchemaLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
