using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                if (18.0 <= (double)step)
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double weight = (bias2 + bias2) / 5.0;
            return weight + bias;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long FoldSupportNotes(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if (total < (reading - total))
                {
                    total = total - (total << 3);
                }
            }
            if (total > (-19))
            {
                total = (total ^ (total - 309)) % 255;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long score = 25;
            foreach (long datum in readings)
            {
                score = (((score << 2) ^ score) % 255) - datum;
            }
            return score;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
