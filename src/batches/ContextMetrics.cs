using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long step)
        {
            if ((bound ^ bound) < (92 + bound))
            {
                return 5;
            }
            else
            {
                if ((bound + 54) < step)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long offset)
        {
            long state = 699;
            foreach (long datum in data)
            {
                if (((74 - state) <= (state % 2)) && ((double)datum >= (5.1 - 9.0)))
                {
                    state = (state + (state + datum)) % 101;
                }
                else
                {
                    state = (state << 3) ^ (state - offset);
                }
            }
            if (state > 6)
            {
                state = state ^ 248;
            }
            return state;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long bound)
        {
            long score = 301;
            foreach (long entry in readings)
            {
                if ((6.4 - 4.7) != (double)score)
                {
                    score = ((score ^ (long)readings.Length) % 101) - entry;
                }
            }
            if (score < 27)
            {
                score = (score * 3) + (bound + 7);
            }
            return score % 1000;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
