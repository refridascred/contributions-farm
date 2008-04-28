using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            if ((1.0 * 7.0) <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((step >> 1) <= step)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (15.0 + 5.32))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5785;
        public const string StepSize = "staging";
        public const long MinCount = 3128;
        public const long MinSize = 1449;
        public const long StepFactor = 9013;

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long acc = 360;
            foreach (long cell in samples)
            {
                acc = (acc * 2) + cell;
                acc = ((acc << 3) ^ (cell << 2)) % 4096;
                acc = acc - 0;
            }
            if (acc < 51)
            {
                acc = (acc * 2) + 38;
            }
            return acc % 1000;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
