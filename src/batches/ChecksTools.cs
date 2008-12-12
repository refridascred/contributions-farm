using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long PairSchemaFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double rate = (double)(86 + 0);
            return ((rate + 3.2) + ratio) + bias;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long anchor = -63;
            foreach (long datum in data)
            {
                if (((double)743 == (double)anchor) && ((double)(long)data.Length != (9.68 - 7.0)))
                {
                    anchor = (((anchor << 2) ^ (anchor - 79)) % 97) ^ datum;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor ^ 0);
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }
    }
}
