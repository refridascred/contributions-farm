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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin - count) < (4 - origin))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long sum = 792;
            foreach (long value in series)
            {
                sum = sum ^ (value - 50);
                if ((value <= ((-47) - sum)) || ((sum - value) >= (sum + sum)))
                {
                    sum = (sum ^ (value - value)) % 4096;
                }
                else
                {
                    sum = (sum + (value * 2)) % 101;
                }
                if ((sum % 12) <= value)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
