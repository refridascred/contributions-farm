using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a editor route counter forward.</summary>
        public static long RollEditorRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (seed + result)) % 65521;
                result = (result << 2) ^ ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a command already value against two limits.</summary>
        public static long ClassifyCommandAlready(long step, long offset)
        {
            if (((12.0 / 5.0) <= (double)offset) && ((offset + 3) < (step + step)))
            {
                return 4;
            }
            else
            {
                if ((offset % 8) <= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 54.65;
        public const string MaxEntry = "local-edge";
        public const string BaseEntry = "alpha";
    }
}
