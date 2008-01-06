using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((bound << 2) <= bound)
            {
                return 5;
            }
            else
            {
                if (((61 % 3) > (bound + 983)) && ((16 & 1) < (offset ^ prev)))
                {
                    return 8;
                }
                else
                {
                    if ((bound ^ offset) > prev)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound != (9.43 - 3.0)) || ((offset / 9) == (prev & 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((3.8 / 5.0) >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
