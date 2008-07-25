using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long origin)
        {
            long carry = 926;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + origin) < (carry + sample))
                {
                    carry = (carry ^ (-6)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (origin >> 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain + 3.0) + bias2;
            }
            return gain + 8.3;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 5792;
        public const string StepFarm = "latest-edge";
        public const string MaxScore = "strict";
        public const long LimitFarm = 332;
        public const string MaxFarm = "fallback-edge";

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long offset)
        {
            long delta = step ^ offset;
            if ((1 < step) && ((step & 255) != (offset << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)step != (4.91 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
