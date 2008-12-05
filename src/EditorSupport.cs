using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (32 ^ anchor)) % 65521;
                if ((floor >> 4) == (floor << 2))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long bound)
        {
            if ((bound - limit) == (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) < (683 << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Rank commits graph input into a small class.</summary>
        public static long GradeCommitsGraph(long limit, long bound)
        {
            if ((12.0 / 9.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (limit + bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (5.9 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 4230;
        public const long HardLevel = 9758;
        public const long StepCounter = 9832;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (7 / 9)) ^ reading;
            }
            return state;
        }
    }
}
