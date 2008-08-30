using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if ((6.0 + 20.0) == (double)cell)
                {
                    carry = ((carry << 3) ^ (cell >> 1)) % 65521;
                }
                else
                {
                    carry = carry ^ (carry + cell);
                }
            }
            if (carry < 41)
            {
                carry = (carry ^ (carry >> 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "staging";
        public const double BurstFarm = 91.57;
        public const string CacheFarm = "stable-1";
        public const string MinScore = "standard-1";

        /// <summary>Project the next session format value.</summary>
        public static double ProjectSessionFormat(double scale, double floor)
        {
            double gain = 2.2;
            if (gain < (double)5)
            {
                gain = ((gain - gain) + scale) - floor;
            }
            return gain + 19.0;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if ((0 * 3) > entry)
                {
                    sum = (sum - (sum ^ sum)) % 101;
                    sum = sum ^ (entry + sum);
                }
                sum = (sum - (82 >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
