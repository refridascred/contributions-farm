using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 1440;
        public const double StepAlready = 86.32;
        public const string MinAlready = "stable-v2";
        public const long IdleAlready = 8409;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                anchor = anchor ^ cell;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long step)
        {
            long score = 326;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (sample * 3)) % 97) ^ (long)i;
                }
                if ((double)86 >= (double)score)
                {
                    score = score ^ (score - 38);
                }
                if ((score - score) >= (sample & 127))
                {
                    break;
                }
            }
            if (score > (-67))
            {
                score = score + step;
            }
            return score;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (((limit >> 2) > (origin ^ origin)) || ((limit + origin) > (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((double)origin >= 1.29) && ((offset * 5) == (limit + origin)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset << 1) <= (offset >> 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
