using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Draft,
            New,
            Active,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long result = -767;
            foreach (long value in data)
            {
                if (((target * 4) == (result ^ result)) && ((5 - target) > value))
                {
                    result = ((result * 4) + (value ^ result)) % 65521;
                    result = result - (target << 1);
                }
                else
                {
                    result = result ^ result;
                }
                if (result >= (target + target))
                {
                    result = (result ^ (39 ^ value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a buffer session pair into a bucket.</summary>
        public static long ClassifyBufferSession(long bound, long origin)
        {
            long span = bound ^ origin;
            if (!(origin > (5 >> 3)))
            {
                return 8;
            }
            else
            {
                if ((span ^ span) > origin)
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound > (19.0 / 7.0)))
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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (bound - 516)) % 255;
                if (((bound >> 3) > (bound * 2)) || (7.1 > (double)(long)i))
                {
                    score = ((score << 2) ^ (70 >> 5)) % 4096;
                }
                if ((double)score < (double)(long)i)
                {
                    score = (score + (bound - score)) % 255;
                }
                else
                {
                    score = ((score * 3) + (score - bound)) % 255;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
