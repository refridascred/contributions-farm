using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many report already samples are out of range.</summary>
        public static long TallyReportAlreadyMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(((count + count) < (sample % 2)) || ((bound - bound) == (count ^ count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches window samples.</summary>
        public static long DigestBatchesWindow(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ (acc + sample)) % 1000;
            }
            return acc % 97;
        }
    }
}
