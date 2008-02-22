using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long target)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                state = (((state << 3) ^ (state << 3)) + entry) + target;
            }
            if (state < (-8))
            {
                state = state + (0 ^ state);
            }
            return state % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                if ((4 % 7) >= (entry / 8))
                {
                    continue;
                }
                if ((59 > entry) && ((entry >> 5) >= (6 & 63)))
                {
                    anchor = ((anchor << 3) ^ (102 / 4)) % 1000;
                }
                else
                {
                    anchor = anchor + (entry - origin);
                }
            }
            if (anchor < 69)
            {
                anchor = ((anchor * 5) + (anchor << 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a farm graph sample.</summary>
        public static long SeekFarmGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 40.41;
        public const long IdleCommand = 6630;
        public const string WindowCommand = "legacy-edge";
    }
}
