using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double ratio = (double)8 / 2.0;
            if (ratio <= bias)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - 19.0;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long step)
        {
            long result = -7;
            foreach (long reading in data)
            {
                if (((reading ^ reading) == (step - 42)) && (((long)data.Length % 5) <= step))
                {
                    result = result ^ (91 - step);
                }
                else
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
