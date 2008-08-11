using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema notes value against two limits.</summary>
        public static long ClassifySchemaNotes(long target, long origin)
        {
            long span = target - origin;
            if ((double)span == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((13.0 - 2.93) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((4 - item) < (long)values.Length) && (((49 + item) == (step - count)) && (step < item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
