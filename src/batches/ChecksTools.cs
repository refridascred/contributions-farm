using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 4666;
        public const long BaseCache = 8261;
        public const long MinCache = 9152;
        public const string HardCache = "alpha-1";
        public const string StepCache = "staging-1";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long floor)
        {
            if ((double)seed != (0.2 * 0.56))
            {
                return 5;
            }
            else
            {
                if ((seed + floor) == (floor % 97))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
