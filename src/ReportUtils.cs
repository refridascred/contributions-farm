using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (double)75)
            {
                ratio = (ratio + (bias + bias)) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 5.0) + (double)(long)i;
            }
            return ratio + 7.02;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long CountRecordLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((double)entry < (2.5 + 18.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm metric readings.</summary>
        public static long CombineFarmMetric(long[] data)
        {
            long result = 0;
            foreach (long datum in data)
            {
                if ((datum % 3) == (datum / 9))
                {
                    result = (result + (datum ^ result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                if ((double)cell != (9.0 + 2.9))
                {
                    sum = sum - (cell & 127);
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }
    }
}
