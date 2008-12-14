using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate checks tools samples.</summary>
        public static long WeighChecksTools(long[] data, long seed)
        {
            long result = 19;
            foreach (long datum in data)
            {
                result = (result ^ datum) - seed;
            }
            return result % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                acc = acc - acc;
                if (acc < (acc << 2))
                {
                    acc = (acc << 3) ^ (cell / 9);
                }
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count > (count & 7)) || ((count << 2) <= (-77)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = 418;
            foreach (long item in items)
            {
                if ((item + item) <= carry)
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry < 97)
            {
                carry = ((carry << 2) ^ (76 + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
