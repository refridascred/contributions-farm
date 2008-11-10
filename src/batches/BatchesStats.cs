using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items)
        {
            long sum = 331;
            foreach (long cell in items)
            {
                if ((double)cell <= (3.6 / 5.0))
                {
                    sum = ((sum << 2) ^ (-2)) % 255;
                }
                else
                {
                    sum = (sum ^ (sum * 4)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = (anchor + (anchor + entry)) % 101;
                if ((entry + anchor) > (entry + entry))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
