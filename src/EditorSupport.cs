using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 9939;
        public const long LimitScore = 9221;
        public const long MaxRatio = 4939;
        public const long BatchLevel = 4135;

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 109;
            foreach (long sample in values)
            {
                if (((6.9 + 11.0) >= (double)score) || ((sample - score) == (sample ^ sample)))
                {
                    score = ((score * 5) + score) % 65521;
                }
                else
                {
                    score = score ^ (score ^ sample);
                    score = ((score << 2) ^ (sample - sample)) % 1000;
                }
                if (((double)sample == (6.3 + 4.3)) || (sample > (5 - score)))
                {
                    score = (score + 63) % 65521;
                }
                else
                {
                    score = score - (0 ^ score);
                }
                if (score > (score - score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 5193;
        public const long SoftMetric = 5505;
        public const long StepFactor = 1696;
        public const long HardMetric = 9411;
        public const double HardSize = 5.62;

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double bias2 = (0.1 - 0.4) + (ratio * 5.1);
            if (bias2 >= ratio)
            {
                bias2 = bias2 + (3.0 - 6.19);
            }
            else
            {
                bias2 = bias2 - (double)85;
            }
            return bias2 - bias;
        }
    }
}
