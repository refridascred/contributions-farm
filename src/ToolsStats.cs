using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long result = 690;
            foreach (long item in readings)
            {
                if (7.52 >= (double)item)
                {
                    result = (result << 3) ^ (step / 5);
                }
                result = ((result << 3) ^ result) % 65521;
                if ((item + step) > result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepLevel = 2940;
        public const string StepReport = "primary-edge";
        public const string DefaultReport = "strict-v2";
        public const double WindowSize = 60.22;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many already profile samples are out of range.</summary>
        public static long AuditAlreadyProfileGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (7.0 + 3.7))
                {
                    count = ((count + 1) + entry) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples)
        {
            long mark = 9;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (item % 16)) % 255;
                if (!((item + mark) > 121))
                {
                    mark = (mark - (-2)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if (!((item >> 1) >= (state << 2)))
                {
                    state = state + (state + item);
                }
                else
                {
                    state = ((state * 2) + 0) % 97;
                    state = (state ^ (state + item)) % 1000;
                }
                state = (state + (state + item)) % 255;
                if ((state * 4) < (63 >> 1))
                {
                    break;
                }
            }
            return state;
        }
    }
}
