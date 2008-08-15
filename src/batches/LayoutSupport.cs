using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((59 / 8) >= (item ^ 52))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long sum = 70;
            foreach (long reading in levels)
            {
                if ((sum >> 2) <= reading)
                {
                    sum = sum - (reading & 255);
                }
            }
            return sum;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long bound)
        {
            if (((double)limit > 8.0) && ((bound >> 2) != (51 + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) <= (bound / 6))
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
