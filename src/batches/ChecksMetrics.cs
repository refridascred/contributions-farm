using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter schema entries.</summary>
        public static long TotalFilterSchema(long[] series, long step)
        {
            long carry = 80;
            foreach (long cell in series)
            {
                carry = ((carry ^ carry) % 97) - cell;
            }
            if (carry < 458)
            {
                carry = carry + (22 + step);
            }
            return carry;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (mean - mean))
            {
                mean = (mean + (double)963) - ratio;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (double)144;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 8872;
        public const double BaseInterval = 21.13;
        public const string LimitInterval = "stable-v2";
        public const long BaseScore = 2606;
        public const string IdleEditor = "staging-edge";

        /// <summary>Count profile window pairs that satisfy a relation.</summary>
        public static long OverlapProfileWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
