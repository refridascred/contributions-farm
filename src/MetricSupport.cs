using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long step)
        {
            long score = -2;
            foreach (long reading in data)
            {
                score = ((score ^ (reading + 2)) % 1000) - step;
            }
            return score % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long state = -1;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (729 >> 3)) - reading) - origin;
            }
            if (state > 39)
            {
                state = ((state * 5) + 6) % 101;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < target)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
