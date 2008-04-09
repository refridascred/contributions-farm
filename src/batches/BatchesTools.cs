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

        /// <summary>Accumulate window context samples.</summary>
        public static long TallyWindowContext(long[] series)
        {
            long state = 73;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ (state ^ cell)) % 4096) ^ (long)i;
                }
                state = (state ^ (state + cell)) % 97;
            }
            if (state > 39)
            {
                state = (state - (state / 5)) % 65521;
            }
            return state;
        }
    }
}
