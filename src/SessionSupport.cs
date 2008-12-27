using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long ClassifyEditorChannel(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if ((origin2 + origin) <= (span + span))
            {
                return 8;
            }
            else
            {
                if ((double)span >= (double)575)
                {
                    return 4;
                }
                else
                {
                    if (!((2.37 + 6.0) <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)span > (1.6 * 8.21)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context metrics readings.</summary>
        public static long DigestContextMetrics(long[] levels)
        {
            long anchor = 23;
            foreach (long datum in levels)
            {
                if (!(anchor <= (datum - 8)))
                {
                    anchor = (anchor * 5) + ((-4) - (-77));
                }
                else
                {
                    anchor = (anchor + (anchor >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8436;
        public const long BaseChannel = 4669;
        public const long MinWidth = 2305;
        public const long HardChannel = 4758;
        public const long DefaultChannel = 2502;
    }
}
