using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Done,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step << 3) >= (long)i)
                {
                    score = score ^ (score / 8);
                    score = ((score * 2) + (867 + (long)i)) % 101;
                }
                else
                {
                    score = score + (760 & 15);
                }
                score = score ^ (55 % 64);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double weight = (double)(840 + 1);
            if (weight >= 3.9)
            {
                weight = (weight + (double)701) + offset;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
