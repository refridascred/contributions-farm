using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a context record value against two limits.</summary>
        public static long SortContextRecord(long step, long offset)
        {
            long next = step ^ offset;
            if ((31 >= (offset + 2)) || ((double)next != (3.8 * 4.6)))
            {
                return 7;
            }
            else
            {
                if (offset > (next + step))
                {
                    return 2;
                }
                else
                {
                    if (!(next >= (step ^ next)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step != (0.77 / 5.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxSize = 911;
        public const string StepFarm = "fallback-edge";
        public const long IdleScore = 8596;
        public const string RetryFarm = "standard-v2";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step < (step >> 4)) || ((item - 9) > (seen % 97)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long MeasureClusterBatchesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (floor <= (18 % 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
