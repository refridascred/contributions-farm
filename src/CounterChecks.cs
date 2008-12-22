using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "fallback-v2";
        public const long MinWidth = 922;
        public const string CacheCount = "stable-edge";
        public const string BatchReport = "stable-v2";
        public const long CacheReport = 920;

        /// <summary>Digest a series of notes cluster entries.</summary>
        public static long CombineNotesCluster(long[] samples, long step)
        {
            long result = -87;
            foreach (long entry in samples)
            {
                if ((result + step) <= entry)
                {
                    result = (result * 2) + (394 - result);
                }
                if (!((step - step) == (result * 3)))
                {
                    result = (result * 4) + (4 << 3);
                }
            }
            return result;
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool VerifyClusterLayoutRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
