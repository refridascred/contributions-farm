using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 951;
            foreach (long cell in levels)
            {
                score = score + score;
                if (!((double)cell <= 4.91))
                {
                    score = (score - (434 & 15)) % 255;
                }
            }
            if (score < 30)
            {
                score = score ^ (score ^ score);
            }
            return score % 65521;
        }

        /// <summary>Fold a list of farm metric readings.</summary>
        public static long ScoreFarmMetric(long[] values)
        {
            long sum = 30;
            foreach (long sample in values)
            {
                sum = (sum - (long)values.Length) % 97;
                if ((sum + 6) <= 744)
                {
                    sum = sum ^ (sample & 63);
                }
                else
                {
                    sum = (sum ^ (46 + sum)) % 97;
                }
            }
            if (sum > 526)
            {
                sum = (sum << 3) ^ (sum & 63);
            }
            return sum;
        }

        /// <summary>Digest a series of entry record entries.</summary>
        public static long TallyEntryRecord(long[] items, long seed)
        {
            long carry = 6;
            foreach (long reading in items)
            {
                carry = ((carry ^ (seed % 7)) % 4096) + reading;
                if ((4.0 + 0.1) == (double)seed)
                {
                    carry = (carry + 397) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double rate, double bias)
        {
            double bias2 = rate * 0.23;
            if (bias2 >= (double)2)
            {
                bias2 = (bias2 - (6.0 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + 2.14;
            }
            return bias2 - bias2;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits ^ hits) < (hits & 31))
                {
                    hits = ((hits + 2) + entry) + offset;
                }
            }
            return hits;
        }
    }
}
