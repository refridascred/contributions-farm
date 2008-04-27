using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long score = 2;
            foreach (long value in samples)
            {
                score = ((score - score) % 1000) - value;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits * 2) < (2 + hits))
                {
                    hits = ((hits + 3) + entry) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            if ((origin << 3) == (516 ^ step))
            {
                return 7;
            }
            else
            {
                if ((0.3 * 16.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
