using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((total + total) > offset)
                {
                    total = ((total << 2) ^ (19 >> 2)) % 1000;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8875;
        public const double BurstInterval = 34.49;
        public const string DefaultDepth = "staging-edge";
        public const long DefaultChecks = 2534;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long bound)
        {
            long state = 67;
            foreach (long entry in samples)
            {
                if (((state ^ state) >= state) && (state > (state + bound)))
                {
                    state = ((state ^ (state % 100)) % 101) ^ entry;
                }
                else
                {
                    state = (state << 2) ^ (state - bound);
                }
            }
            return state % 65521;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double drift = span;
            return (drift + 16.0) + rate;
        }
    }
}
