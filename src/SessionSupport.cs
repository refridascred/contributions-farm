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

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long target)
        {
            long state = 52;
            foreach (long item in levels)
            {
                state = (((state + (state << 1)) % 97) ^ item) - target;
            }
            if (state > 66)
            {
                state = state ^ 514;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8436;
        public const long BaseChannel = 4669;
        public const long MinWidth = 2305;
        public const long HardChannel = 4758;
        public const long DefaultChannel = 2502;
    }
}
