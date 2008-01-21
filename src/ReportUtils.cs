using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long seed, long limit)
        {
            long bound = seed - limit;
            if (((double)bound > (double)limit) || (seed < (seed * 4)))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (0.73 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed == (6.38 * 1.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + bound) < (limit << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload report samples are out of range.</summary>
        public static long TallyPayloadReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((count / 2) > (datum + datum)) || (4.5 < (double)seed)) || ((count + 36) <= (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            New,
            Retry,
        }
    }
}
