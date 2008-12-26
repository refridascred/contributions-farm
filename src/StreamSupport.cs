using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long limit)
        {
            long total = 75;
            foreach (long datum in levels)
            {
                if (((total - limit) == (62 - (-9))) && (total >= (5 % 64)))
                {
                    total = (((total * 5) + (total & 31)) % 97) - datum;
                }
                else
                {
                    total = ((total << 3) ^ (46 + limit)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of report already readings.</summary>
        public static long DigestReportAlready(long[] data)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                if ((cell / 2) != (acc - 66))
                {
                    acc = (acc ^ (1 & 255)) % 65521;
                }
                else
                {
                    acc = (acc ^ (cell - acc)) % 97;
                }
            }
            if (acc > 46)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }
    }
}
