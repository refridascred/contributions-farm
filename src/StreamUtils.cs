using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 35;
            foreach (long value in values)
            {
                if ((value / 9) < (mix << 2))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
                if ((value - mix) <= value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer route value from a seed.</summary>
        public static long RollBufferRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (offset / 8)) + entry;
            }
            if (anchor < 806)
            {
                anchor = anchor ^ offset;
            }
            return anchor;
        }
    }
}
