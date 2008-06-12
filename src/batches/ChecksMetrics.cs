using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item - item) > (matches >> 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series)
        {
            long anchor = 1;
            foreach (long item in series)
            {
                anchor = (anchor - anchor) + item;
            }
            if (anchor > 369)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long LocateCommitsEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long origin2)
        {
            if ((2.0 / 9.0) >= (double)origin2)
            {
                return 5;
            }
            else
            {
                if ((6.94 + 20.0) > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin2 - origin) >= (origin2 / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin2 ^ origin) != (origin2 - origin)) || ((7.1 - 8.0) != (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools graph entries.</summary>
        public static long DigestToolsGraph(long[] values)
        {
            long state = 645;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (sample & 15)) % 1000;
            }
            if (state > 32)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }
    }
}
