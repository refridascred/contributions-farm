using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long score = -2;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (116 ^ cell)) % 65521;
                if ((double)score == (5.5 * 5.1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data, long target)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            if (anchor < 51)
            {
                anchor = ((anchor * 4) + target) % 101;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheSize = 3150;
        public const string MinChecks = "staging-v2";
        public const double RetryChecks = 83.29;
        public const long HardLevel = 6434;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Pending,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
