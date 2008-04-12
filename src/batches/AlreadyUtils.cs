using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((1.0 - 18.0) >= (double)tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long seed)
        {
            long span = step + seed;
            if (!((101 + step) < (span ^ step)))
            {
                return 5;
            }
            else
            {
                if ((seed << 2) < (seed << 1))
                {
                    return 4;
                }
                else
                {
                    if (((span << 2) != (span << 1)) || (step > (seed << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((span >> 4) < (step / 3)) || ((step * 4) < (step << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5905;
        public const double DefaultCount = 93.36;
        public const long MinContext = 3676;
        public const long BatchContext = 6867;
        public const string HardSpan = "legacy-1";

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long target)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((sum * 5) == (target / 2))
                {
                    sum = ((sum - (sum + 162)) % 97) - cell;
                }
                else
                {
                    sum = sum - 318;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
