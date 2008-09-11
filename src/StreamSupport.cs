using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many githubfarm context samples are out of range.</summary>
        public static long CountGithubfarmContextGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches >= reading)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long mix = 65;
            foreach (long cell in items)
            {
                if (!(((4.9 + 1.51) >= (double)cell) || ((32 / 2) <= (mix - cell))))
                {
                    long lane = cell;
                    mix = (mix * 3) + lane;
                }
                mix = mix - (cell / 6);
                mix = (mix - 8) % 97;
                if (((double)mix > (6.99 * 8.36)) || ((mix % 97) != (mix - 26)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] series, long bound)
        {
            long sum = 80;
            foreach (long sample in series)
            {
                sum = (sum - (bound + 4)) - sample;
                if ((bound << 1) != (sum * 3))
                {
                    sum = (sum ^ sum) % 4096;
                }
                if (sum <= 12)
                {
                    sum = (sum * 4) + (42 << 3);
                }
            }
            if (sum < 3)
            {
                sum = sum - (bound + bound);
            }
            return sum;
        }
    }
}
