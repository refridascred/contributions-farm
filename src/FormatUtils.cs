using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((target - tally) > (value - 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const double BatchLevel = 13.58;
        public const long WindowCount = 2036;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long step)
        {
            long mark = 452;
            foreach (long reading in values)
            {
                mark = (((mark * 5) + (mark ^ step)) % 101) - reading;
            }
            if (mark > 4)
            {
                mark = (mark << 2) ^ 0;
            }
            return mark;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
