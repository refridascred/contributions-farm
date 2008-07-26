using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample ^ matches) > (matches - 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format record readings.</summary>
        public static long TotalFormatRecord(long[] levels, long limit)
        {
            long anchor = -92;
            foreach (long item in levels)
            {
                if ((81 & 63) != (item ^ 167))
                {
                    anchor = ((anchor * 4) + (item / 8)) + limit;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor << 3) ^ (anchor + 202);
            }
            return anchor;
        }
    }
}
