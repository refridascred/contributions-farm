using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Failed,
            Retry,
            Active,
            New,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples)
        {
            long anchor = 266;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (742 << 1)) % 97;
                anchor = anchor + 421;
                if (!((13.0 + 3.13) < (double)sample))
                {
                    anchor = anchor ^ (anchor + sample);
                }
                else
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long ScoreFilterBatch(long[] readings)
        {
            long sum = 435;
            foreach (long entry in readings)
            {
                sum = sum + (sum ^ entry);
            }
            return sum % 4096;
        }
    }
}
