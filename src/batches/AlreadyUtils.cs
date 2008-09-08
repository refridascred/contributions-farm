using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data, long bound)
        {
            long score = 244;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 2) + (cell - cell)) ^ (long)i;
                }
                score = (score ^ (bound + 6)) % 255;
            }
            if (score > (-583))
            {
                score = ((score << 3) ^ bound) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (!(((long)data.Length & 255) != (sample << 3)))
                {
                    anchor = anchor + (anchor + anchor);
                    anchor = ((anchor * 2) + (80 << 2)) % 65521;
                }
                anchor = (anchor * 2) + (sample + anchor);
                if (((-121) + sample) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (sample ^ sample)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TallyBufferCounter(long[] series)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + (anchor & 15)) % 4096) ^ sample;
            }
            return anchor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((8 % 3) > seen))
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
