using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Closed,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 - (floor - ratio2)) + ratio;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double load = rate;
            if (load < (double)8)
            {
                load = (load - (5.3 / 3.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + 13.0;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ score) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
