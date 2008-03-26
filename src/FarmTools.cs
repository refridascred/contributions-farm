using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] values, long step)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 2) ^ state) % 1000;
                if ((state % 16) < step)
                {
                    state = (state << 3) ^ (datum & 127);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-9) > (sample / 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                if ((8 ^ item) > (511 % 60))
                {
                    anchor = (anchor + item) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
