using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes report values into a single score.</summary>
        public static long TotalNotesReport(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state + (sample + sample)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long DigestClusterStats(long[] readings, long bound)
        {
            long acc = 87;
            foreach (long reading in readings)
            {
                if ((double)bound < (double)acc)
                {
                    acc = acc ^ (bound << 1);
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double weight = scale;
            return (weight + scale) + span;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 1439;
        public const double WindowRecord = 7.15;
        public const long LimitRecord = 6818;
    }
}
