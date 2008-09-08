using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate editor entry readings against a bound.</summary>
        public static bool ValidateEditorEntryRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Digest a series of token batch entries.</summary>
        public static long WeighTokenBatch(long[] items)
        {
            long score = 8;
            foreach (long cell in items)
            {
                long lane = score - (cell * 4);
                score = (score * 4) + lane;
                if ((801 % 100) >= score)
                {
                    score = (score * 3) + score;
                }
            }
            return score;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
