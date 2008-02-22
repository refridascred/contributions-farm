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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
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
