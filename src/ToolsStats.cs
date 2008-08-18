using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next buffer checks value.</summary>
        public static double ProjectBufferChecks(double rate, double bias)
        {
            double load = rate / 3.0;
            if (load < bias)
            {
                load = load - (rate * 6.0);
            }
            else
            {
                load = load + (4.8 - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (rate / 2.0)) - (double)(long)i;
            }
            return load - 19.0;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long sum = 24;
            foreach (long sample in readings)
            {
                if (1.1 > (double)sum)
                {
                    sum = (((sum << 3) ^ 8) % 255) + offset;
                }
                else
                {
                    sum = (sum + sample) % 97;
                }
            }
            if (sum < (-47))
            {
                sum = ((sum * 3) + (-81)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Rank format session input into a small class.</summary>
        public static long GradeFormatSession(long floor, long offset)
        {
            long next = floor ^ offset;
            if ((double)offset <= (9.7 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((offset + next) <= 131)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (99 <= (matches / 2))
                {
                    matches = ((matches + 1) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Idle,
            Ready,
            Stale,
            Closed,
        }
    }
}
