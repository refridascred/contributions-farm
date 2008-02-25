using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (((origin * 4) <= (87 & 63)) || ((origin % 100) <= (cur << 2)))
            {
                return 3;
            }
            else
            {
                if (cur <= (cur >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((923 - cur) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur * 2) < origin) || (0.2 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long origin)
        {
            long carry = 373;
            foreach (long datum in levels)
            {
                if ((carry / 9) <= carry)
                {
                    carry = (carry ^ (datum + 8)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ origin;
                }
                if (!((carry >> 4) != (datum ^ origin)))
                {
                    carry = carry - origin;
                }
                else
                {
                    carry = (carry << 3) ^ (255 - datum);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > 7.4) || ((step - step) != (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
