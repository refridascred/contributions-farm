using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((40 ^ origin) == (108 + matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                if ((datum + 232) > 33)
                {
                    result = result + (result << 2);
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if ((double)seed == (3.41 + 13.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 == (double)step) || ((step * 5) >= (step << 3)))
                {
                    return 8;
                }
                else
                {
                    if (((step + seed) <= (37 << 1)) && ((14.0 + 9.6) <= (double)seed))
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
}
