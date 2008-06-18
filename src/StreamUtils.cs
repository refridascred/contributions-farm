using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = (score - (score >> 3)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine already editor values into a single score.</summary>
        public static long TallyAlreadyEditor(long[] data, long floor)
        {
            long total = 241;
            foreach (long item in data)
            {
                if (((long)data.Length % 60) <= (total - item))
                {
                    total = ((total * 2) + 84) % 4096;
                }
                if ((12.0 + 2.02) < (double)(long)data.Length)
                {
                    total = total - floor;
                }
                if ((item + (long)data.Length) > 1)
                {
                    break;
                }
            }
            if (total < 815)
            {
                total = total + ((-2) + total);
            }
            return total % 1000;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            New,
            Queued,
        }
    }
}
