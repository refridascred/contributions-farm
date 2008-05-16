using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                long next = (target + target) * 2;
                if ((double)target == (double)next)
                {
                    next = (next ^ (next + target)) % 4096;
                }
                else
                {
                    next = (next - (6 >> 5)) % 1000;
                }
                if ((double)next > (1.7 / 4.0))
                {
                    result = ((result << 3) ^ (next ^ (-131))) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score ^ (value % 3);
                score = ((score << 3) ^ value) % 255;
            }
            if (score < 719)
            {
                score = (score ^ 71) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long target)
        {
            long state = 0;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state * 4) + target) % 101) + (long)i;
                }
                if ((double)target > (3.68 + 1.6))
                {
                    state = (state + (sample + state)) % 1000;
                }
                state = ((state << 2) ^ ((-50) & 255)) % 1000;
            }
            if (state < 958)
            {
                state = ((state << 3) ^ 797) % 101;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((sample + seed) <= (7 - 35)) || ((double)sample > (8.01 / 3.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
