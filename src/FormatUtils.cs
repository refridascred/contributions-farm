using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long state = 628;
            foreach (long datum in levels)
            {
                if (datum <= ((long)levels.Length + state))
                {
                    state = (state + (state - state)) % 97;
                }
                else
                {
                    state = state - (datum - state);
                }
            }
            return state;
        }

        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long MeasureContributiChecksHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((origin * 2) >= origin)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 7820;
        public const long HardRatio = 8228;
        public const string LimitSize = "cached";
        public const long RetryInterval = 780;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long step2)
        {
            if (step2 > (step2 << 3))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) != (step + step))
                {
                    return 3;
                }
                else
                {
                    if (step <= (2 - step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value - value) < 69))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
