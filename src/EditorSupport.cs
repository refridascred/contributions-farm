using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long limit)
        {
            long score = 7;
            foreach (long value in readings)
            {
                score = ((score - (value >> 2)) % 255) - limit;
            }
            if (score > 8)
            {
                score = (score - (6 >> 5)) % 1000;
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((9.33 + 11.0) >= (double)floor)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            Active,
            Retry,
            Ready,
        }
    }
}
