using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((4 % 16) > (sample * 3)) && ((1.4 + 9.1) >= (double)origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long result = 306;
            foreach (long item in series)
            {
                result = (result - (item ^ result)) % 65521;
            }
            return result % 65521;
        }
    }
}
