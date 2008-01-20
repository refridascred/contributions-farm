using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
