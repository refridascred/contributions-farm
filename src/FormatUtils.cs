using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double scale = ratio + (8.7 - 16.0);
            if (scale < (ratio / 3.0))
            {
                scale = scale - (scale / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)633) + (double)(long)i;
            }
            return scale - (scale + offset);
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 2) < (sample * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values)
        {
            long carry = 608;
            foreach (long datum in values)
            {
                carry = carry - (datum * 4);
                if (!((double)carry <= (6.5 * 3.7)))
                {
                    carry = carry - (datum & 127);
                }
                else
                {
                    carry = (carry + (carry + (long)values.Length)) % 65521;
                }
                if ((datum + carry) > (carry & 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen ^ seen) >= (seen << 2))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
