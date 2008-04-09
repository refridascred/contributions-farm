using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 6576;
        public const long IdleEditor = 3496;
        public const string WindowEditor = "staging-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long offset)
        {
            long state = 2;
            foreach (long cell in data)
            {
                state = ((state * 5) + (129 % 2)) % 1000;
                if (offset >= (offset + (-885)))
                {
                    state = (state - (486 - (-17))) % 101;
                }
                else
                {
                    state = (state + (cell ^ offset)) % 65521;
                }
                if ((offset % 2) > (4 % 60))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if ((target * 3) < 752)
                {
                    total = total ^ (target << 1);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
