using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 2) == (value << 3))
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3117;
        public const long StepStats = 3566;
        public const string BatchFactor = "strict";
        public const long SoftStats = 2254;
        public const long RetrySize = 9123;

        /// <summary>Measure how many metric account samples are out of range.</summary>
        public static long MeasureMetricAccountOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((96 % 64) > (2 + floor)) || ((floor >> 1) <= (490 * 4)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long RankCommitsStats(long offset, long step)
        {
            long prev = offset ^ step;
            if (!(step <= (offset / 5)))
            {
                return 5;
            }
            else
            {
                if ((17.0 - 3.9) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if (prev >= (offset * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 2) > (step - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token route entry that matches the target.</summary>
        public static long SeekTokenRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
