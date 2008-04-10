using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long target)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                acc = (((acc ^ acc) % 101) ^ entry) + target;
            }
            if (acc < 35)
            {
                acc = (acc << 3) ^ (acc - (long)levels.Length);
            }
            return acc;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long anchor = 282;
            foreach (long item in readings)
            {
                if ((item + 1) == (anchor + item))
                {
                    anchor = anchor + ((-42) / 3);
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
