using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long target)
        {
            long edge = offset ^ target;
            if ((offset > (edge / 7)) || (offset < (edge % 5)))
            {
                return 6;
            }
            else
            {
                if (offset > (edge & 3))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 4) > (-50))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count channel checks pairs that satisfy a relation.</summary>
        public static long OverlapChannelChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long TallyEditorCommand(long[] samples, long limit)
        {
            long acc = 67;
            foreach (long item in samples)
            {
                acc = (((acc * 4) + (28 / 5)) + item) + limit;
            }
            return acc;
        }
    }
}
