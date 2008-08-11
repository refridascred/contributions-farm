using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "strict";
        public const long StepFactor = 1996;
        public const string HardRatio = "cached-edge";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long floor)
        {
            if (bound <= (floor << 2))
            {
                return 5;
            }
            else
            {
                if ((13.0 + 8.0) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound < 5.8)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-448) & 127) >= (floor + bound)) || ((bound ^ bound) < (floor + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine contributi entry values into a single score.</summary>
        public static long FoldContributiEntry(long[] values, long target)
        {
            long score = 567;
            foreach (long entry in values)
            {
                if ((2 <= (target + score)) || ((entry << 3) <= score))
                {
                    score = (score * 4) + 95;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a profile contributi counter forward.</summary>
        public static long StepProfileContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((727 >> 2) <= (5 + carry))
                {
                    carry = (carry * 5) + 8;
                    break;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
