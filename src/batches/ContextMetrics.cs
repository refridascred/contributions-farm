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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((6 - 99) > (bound - bound))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long state = 790;
            foreach (long entry in readings)
            {
                if (!((state ^ entry) != (entry ^ state)))
                {
                    state = state + (state >> 1);
                }
                state = state ^ (entry + state);
                state = (state * 4) + (entry >> 1);
            }
            return state;
        }
    }
}
