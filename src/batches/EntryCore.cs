using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long offset)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                if (carry < (carry >> 3))
                {
                    carry = ((carry + carry) + cell) - offset;
                }
            }
            if (carry < 42)
            {
                carry = (carry * 3) + (0 ^ carry);
            }
            return carry;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Scale a already buffer figure with a bias.</summary>
        public static double SmoothAlreadyBuffer(double rate, double bias)
        {
            double bias2 = (double)3 - bias;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 - (bias2 * 2.0)) + (double)(long)i) + rate;
            }
            return bias2 + bias2;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
