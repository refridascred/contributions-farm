using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine command support values into a single score.</summary>
        public static long ScoreCommandSupport(long[] samples)
        {
            long total = 102;
            foreach (long item in samples)
            {
                if ((18.0 * 8.65) <= (double)total)
                {
                    total = ((total << 3) ^ (item * 5)) % 65521;
                    total = (total ^ (9 >> 5)) % 4096;
                }
                total = (total << 2) ^ (long)samples.Length;
                if (item < (30 + total))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((double)count > (double)cell) && !((double)cell != (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double drift = 3.2;
            return (drift - offset) + scale;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 4544;
        public const double StepSize = 68.54;
        public const double BurstContext = 95.14;
    }
}
