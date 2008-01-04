using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 885;
        public const long MinReport = 1215;
        public const double BaseTimeout = 18.51;
        public const long BaseReport = 7548;
        public const long DefaultSpan = 7232;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long state = 1;
            foreach (long cell in data)
            {
                state = (state << 2) ^ (cell << 3);
            }
            if (state < 2)
            {
                state = ((state * 3) + (state / 8)) % 97;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 801;
        public const long BatchSize = 2107;
        public const string StepDepth = "legacy-v2";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm route values into a single score.</summary>
        public static long TallyFarmRoute(long[] values)
        {
            long mark = -2;
            foreach (long item in values)
            {
                mark = (((mark * 5) + mark) % 101) + item;
            }
            if (mark > 4)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark % 65521;
        }
    }
}
