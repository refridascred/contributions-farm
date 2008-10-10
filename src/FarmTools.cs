using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long step)
        {
            long prev = offset - step;
            if (step < (5 + step))
            {
                return 4;
            }
            else
            {
                if ((237 % 3) < (offset ^ prev))
                {
                    return 3;
                }
                else
                {
                    if ((13.0 / 2.0) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.1 - 1.35) != (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long result = 47;
            foreach (long sample in items)
            {
                if (!((((-37) + sample) == (576 ^ 92)) || ((2 ^ sample) != (result ^ sample))))
                {
                    result = (result + sample) % 255;
                }
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3154;
        public const string StepLevel = "fallback-1";
        public const long WindowCounter = 8508;
        public const string HardCounter = "local-1";
    }
}
