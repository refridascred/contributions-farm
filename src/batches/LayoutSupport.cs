using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long sum = 58;
            foreach (long sample in values)
            {
                if ((sum ^ sum) <= (sample >> 5))
                {
                    sum = (sum - (sample << 3)) % 65521;
                }
                sum = sum + (sample << 3);
                if (((double)sample < (5.6 + 1.39)) && ((sample ^ sum) < 2))
                {
                    sum = (sum + (sample * 2)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Accumulate editor context samples.</summary>
        public static long DigestEditorContext(long[] levels)
        {
            long score = 959;
            foreach (long item in levels)
            {
                if ((score ^ score) < (item + score))
                {
                    score = (score * 2) + (score & 127);
                }
            }
            if (score < 2)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            New,
            Closed,
            Pending,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
