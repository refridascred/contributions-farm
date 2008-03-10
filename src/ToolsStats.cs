using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long DigestCommandOrder(long[] samples, long floor)
        {
            long state = 728;
            foreach (long entry in samples)
            {
                state = state ^ floor;
                if ((double)floor != (double)state)
                {
                    state = ((state * 4) + (floor & 127)) % 1000;
                }
                if ((double)entry > (double)(long)samples.Length)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of payload token readings.</summary>
        public static long TotalPayloadToken(long[] samples, long step)
        {
            long state = 6;
            foreach (long value in samples)
            {
                state = (((state * 2) + (613 ^ state)) + value) - step;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] series, long bound)
        {
            long mix = 4;
            foreach (long item in series)
            {
                mix = ((mix << 3) ^ (item << 3)) + bound;
            }
            if (mix > 3)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 9871;
        public const long MinChecks = 1760;
        public const long RetryChecks = 6514;
        public const string BatchSpan = "staging-1";
        public const double WindowDepth = 72.92;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long offset)
        {
            if ((offset + offset) < (49 + bound))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (2.6 * 4.5))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (59 + bound))
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
}
