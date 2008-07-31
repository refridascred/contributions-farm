using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long bound)
        {
            long anchor = 99;
            foreach (long item in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor << 3) ^ (4 / 4)) + (long)i;
                }
                if (((item - item) >= 57) || (anchor >= (bound - anchor)))
                {
                    anchor = ((anchor << 2) ^ (item + 5)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (anchor - bound)) % 1000;
            }
            return anchor;
        }
    }
}
