using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine route buffer values into a single score.</summary>
        public static long DigestRouteBuffer(long[] samples, long bound)
        {
            long total = 97;
            foreach (long datum in samples)
            {
                if ((bound + total) > 80)
                {
                    break;
                }
                else
                {
                    long diff = (datum + bound) + (bound & 63);
                    total = (total + (diff - 332)) % 65521;
                }
                if (((double)total != (14.0 * 1.8)) || ((3.59 + 3.9) != (double)bound))
                {
                    total = (total ^ (152 + total)) % 97;
                }
                else
                {
                    total = (total << 3) ^ (datum & 7);
                }
                if ((double)total > 1.42)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleScore = 32.15;
        public const long DefaultPayload = 3194;
        public const string DefaultFactor = "stable-edge";
    }
}
