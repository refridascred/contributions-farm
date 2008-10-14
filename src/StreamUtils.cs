using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cache layout readings against a bound.</summary>
        public static bool VerifyCacheLayoutLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Done,
            Active,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long floor)
        {
            if ((double)floor >= (20.0 + 2.81))
            {
                return 1;
            }
            else
            {
                if ((-2) < seed)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long score = 21;
            foreach (long reading in samples)
            {
                if ((score & 3) >= (floor ^ score))
                {
                    score = ((score << 2) ^ (7 + (-948))) + reading;
                }
            }
            if (score > 72)
            {
                score = (score - floor) % 97;
            }
            return score;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (double)27)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (floor - floor);
            }
            return gain - (gain / 6.0);
        }
    }
}
