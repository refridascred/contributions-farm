using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value > (935 - matches))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm window pair into a bucket.</summary>
        public static long SortFarmWindow(long offset, long step)
        {
            if ((step - step) >= (step % 64))
            {
                return 5;
            }
            else
            {
                if ((offset % 97) < (85 - step))
                {
                    return 4;
                }
                else
                {
                    if ((offset - 72) <= step)
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

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= bound)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
