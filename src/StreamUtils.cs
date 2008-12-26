using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stream editor reading by value.</summary>
        public static long LocateStreamEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Dropped,
            Done,
            Synced,
            New,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long bound)
        {
            long bound2 = floor + bound;
            if ((double)bound2 != (18.0 + 4.2))
            {
                return 0;
            }
            else
            {
                if (5.2 >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((5.0 - 17.0) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor != (double)104)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = -72;
            foreach (long datum in readings)
            {
                if (datum >= (16 + 9))
                {
                    mix = (mix * 5) + (datum & 15);
                }
            }
            return mix;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] items)
        {
            long anchor = 903;
            foreach (long entry in items)
            {
                if ((2.8 + 6.0) == (double)anchor)
                {
                    anchor = (anchor * 3) + (entry + entry);
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 4096;
                }
                if (entry > (entry << 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
