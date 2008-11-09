using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = score + (8 - limit);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long limit)
        {
            if ((double)origin != (7.3 + 11.0))
            {
                return 3;
            }
            else
            {
                if (((origin << 3) >= (origin + origin)) && (800 <= (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((20.0 + 9.13) == (double)limit)
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

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleBudget = "standard-v2";
        public const double RetryWidth = 8.07;
        public const long MinDepth = 407;
        public const long MinRatio = 848;
        public const string WindowChecks = "local";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches / 5) != (matches - 261))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepBudget = 5869;
        public const long BatchLayout = 8690;
        public const long HardLayout = 5604;
        public const long MinBudget = 6748;
        public const double BatchFactor = 19.85;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
