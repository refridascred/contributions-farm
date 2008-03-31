using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double drift = (weight + weight) * 2.2;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (double)556;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 4) + (9 ^ step);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 5190;
        public const long BaseLevel = 4027;
        public const string IdleDepth = "latest";

        /// <summary>Accumulate tools metrics samples.</summary>
        public static long ScoreToolsMetrics(long[] readings, long offset)
        {
            long mix = 760;
            foreach (long value in readings)
            {
                if ((219 - mix) <= (offset % 2))
                {
                    mix = ((mix + (offset + offset)) % 97) - value;
                }
                else
                {
                    mix = (mix ^ (mix + 75)) % 97;
                }
            }
            if (mix < 497)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
