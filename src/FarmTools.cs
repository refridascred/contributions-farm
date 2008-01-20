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

        /// <summary>Accumulate commits route samples.</summary>
        public static long WeighCommitsRoute(long[] levels, long target)
        {
            long acc = 41;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - ((long)i + 19)) % 97;
                }
                acc = acc ^ (target + value);
            }
            if (acc < 232)
            {
                acc = acc + ((-2) % 5);
            }
            return acc;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
