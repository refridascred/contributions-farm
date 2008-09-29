using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                long next = 45 + 22;
                if ((14.0 - 10.0) >= (double)next)
                {
                    score = (score - (score ^ next)) % 255;
                    break;
                }
                else
                {
                    next = next - (next + next);
                }
                score = ((score * 2) + datum) % 101;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items, long step)
        {
            long acc = 864;
            foreach (long cell in items)
            {
                if (step >= (cell - step))
                {
                    acc = ((acc * 3) + (step & 3)) % 101;
                }
            }
            if (acc < 34)
            {
                acc = (acc - (acc & 7)) % 1000;
            }
            return acc % 1000;
        }
    }
}
