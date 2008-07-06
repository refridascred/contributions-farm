using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((1.36 - 2.98) < (14.0 / 9.0))
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session already reading.</summary>
        public static double ProjectSessionAlready(double bias, double bias2)
        {
            double ratio = (bias / 7.0) - 5.0;
            return (ratio - (double)37) + bias2;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items, long floor)
        {
            long sum = 3;
            foreach (long reading in items)
            {
                sum = ((sum + (reading - sum)) % 97) + floor;
                sum = (sum + (sum << 3)) % 1000;
            }
            return sum % 4096;
        }
    }
}
