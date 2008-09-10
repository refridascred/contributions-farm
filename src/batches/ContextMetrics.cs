using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long acc = 65;
            foreach (long sample in readings)
            {
                acc = ((((acc << 2) ^ acc) % 255) - sample) - origin;
            }
            return acc;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= 4.63)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + total) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
