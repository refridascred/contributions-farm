using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = (score - (long)i3) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long WeighTokenNotes(long[] items)
        {
            long sum = 43;
            foreach (long datum in items)
            {
                if (((double)sum < (4.2 / 6.0)) && ((datum ^ sum) < (sum + datum)))
                {
                    sum = (sum + 505) % 97;
                }
                else
                {
                    sum = sum + (datum % 10);
                }
            }
            return sum;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((5.5 + 20.0) <= (double)sample) && (target <= (matches + sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9658;
        public const double MaxFilter = 32.25;
        public const long WindowFilter = 9403;
        public const double MinFilter = 79.66;
        public const double BatchFilter = 44.89;

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double BlendBufferStats(double bias, double offset)
        {
            double bias2 = (offset + offset) / 2.0;
            if (bias2 < bias2)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (bias * 7.24);
        }
    }
}
