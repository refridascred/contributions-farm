using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((offset - (long)i) <= (offset ^ (long)i)))
                {
                    anchor = ((anchor * 4) + (long)i) % 255;
                }
                anchor = ((anchor * 4) + (anchor / 8)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)seen < (0.5 * 8.4)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
