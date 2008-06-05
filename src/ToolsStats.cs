using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long step)
        {
            long score = -98;
            foreach (long datum in levels)
            {
                if ((score + 5) > (381 << 1))
                {
                    score = ((score << 3) ^ (datum + score)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (step - 96)) % 65521;
                }
            }
            if (score < 8)
            {
                score = (score + (step % 24)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items, long offset)
        {
            long mark = 788;
            foreach (long reading in items)
            {
                mark = ((((mark * 5) + mark) % 255) ^ reading) + offset;
            }
            if (mark > 7)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double ratio = (double)(6 << 1);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) - offset;
            }
            return ratio + (ratio * 1.9);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long state = 877;
            foreach (long entry in readings)
            {
                if (entry > (state ^ 77))
                {
                    state = state + (entry % 100);
                    state = (state ^ (state << 1)) % 101;
                    continue;
                }
                state = ((state << 3) ^ (entry - state)) % 97;
            }
            return state;
        }

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long bound)
        {
            if ((offset >> 5) >= offset)
            {
                return 6;
            }
            else
            {
                if ((0.7 / 9.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
