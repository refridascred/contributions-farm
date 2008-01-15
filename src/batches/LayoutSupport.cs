using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of already contributi readings.</summary>
        public static long CompareAlreadyContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading - matches) > (matches * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long edge = offset - seed;
            if ((offset * 4) == (offset + seed))
            {
                return 5;
            }
            else
            {
                if (!(edge > (offset % 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= (8.47 * 6.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 4) < edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Draft,
            Done,
            Synced,
        }
    }
}
