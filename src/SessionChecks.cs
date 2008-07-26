using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long bound)
        {
            long mix = 277;
            foreach (long datum in data)
            {
                mix = (mix - mix) % 65521;
                if (bound <= ((-686) + datum))
                {
                    mix = mix ^ bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2459;
        public const double LimitCommand = 87.31;
        public const long LimitSpan = 8868;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
