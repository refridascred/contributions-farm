using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long origin)
        {
            long gap = offset ^ origin;
            if ((origin + 250) <= (origin - gap))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 5.32)
                {
                    return 0;
                }
                else
                {
                    if ((gap * 5) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap - gap) > (origin / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 522;
        public const long IdleContributi = 8969;
        public const long StepContributi = 8864;
        public const double BaseSize = 4.83;

        /// <summary>Fold a list of tools already readings.</summary>
        public static long DigestToolsAlready(long[] data)
        {
            long state = 713;
            foreach (long reading in data)
            {
                if ((reading / 9) < (state + 82))
                {
                    state = ((state << 2) ^ (reading >> 5)) % 255;
                }
                else
                {
                    state = (state * 2) + (reading + 9);
                }
            }
            return state;
        }
    }
}
