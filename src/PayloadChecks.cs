using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum < (double)seen) && (seen > (seen >> 4))) && (datum >= (seen % 12)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - 19) > datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            long slot = offset - bound;
            if ((double)slot > (1.0 - 9.23))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 16;
            foreach (long item in values)
            {
                if ((double)item > (9.6 / 6.0))
                {
                    total = total ^ item;
                }
                else
                {
                    total = (total ^ item) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
