using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a context window reading by value.</summary>
        public static long SeekContextWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long GradeEntryTools(long limit, long seed)
        {
            long next = limit ^ seed;
            if ((seed / 4) >= (next + next))
            {
                return 2;
            }
            else
            {
                if (seed < (seed - limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Ready,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Find the first batch layout entry that matches the target.</summary>
        public static long LocateBatchLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
