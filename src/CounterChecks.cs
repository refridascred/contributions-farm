using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long step)
        {
            if ((offset >= (step + step)) && ((51 << 1) < (offset * 3)))
            {
                return 2;
            }
            else
            {
                if ((offset << 3) < (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if (((5.5 / 6.0) == (double)offset) && ((offset - offset) < (385 / 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + 589) < (offset - step)) || ((4.43 * 18.0) <= (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Active,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((20.0 - 8.0) != (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 2) ^ 68) % 1000) - (long)i2;
                }
                if ((756 >> 4) != ((long)i % 97))
                {
                    mix = ((mix * 5) + mix) % 4096;
                }
                mix = (mix * 3) + (8 - origin);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count checks batches pairs that satisfy a relation.</summary>
        public static long MatchChecksBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
