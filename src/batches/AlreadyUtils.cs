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

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long step)
        {
            long result = 298;
            foreach (long cell in items)
            {
                result = (result ^ 77) % 1000;
                if (!((result / 4) <= (step % 8)))
                {
                    result = (result + (step - 162)) % 101;
                }
                result = (result + (cell - result)) % 97;
                if ((19.0 - 1.0) <= (double)cell)
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = result - (step >> 4);
            }
            return result;
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
