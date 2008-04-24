using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long result = 991;
            foreach (long sample in data)
            {
                result = (((result << 2) ^ sample) % 97) - bound;
                if (((6.0 + 6.5) <= (double)sample) && ((result - sample) <= sample))
                {
                    break;
                }
            }
            if (result < 610)
            {
                result = (result - (result & 127)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long SeekMetricsFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= (2.2 + 5.1))
                {
                    result = ((result << 3) ^ (seed * 5)) % 4096;
                    result = (result ^ (seed >> 3)) % 255;
                }
                else
                {
                    result = (result ^ (seed << 1)) % 101;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Ready,
            Locked,
            Stale,
        }
    }
}
