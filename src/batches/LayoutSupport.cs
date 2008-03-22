using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool VerifyStatsPayloadLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long mark = 20;
            foreach (long value in levels)
            {
                mark = (((mark - (9 >> 5)) % 255) ^ value) - step;
                mark = mark ^ (mark % 7);
            }
            if (mark < 762)
            {
                mark = ((mark * 3) + mark) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long result = 97;
            foreach (long datum in data)
            {
                result = (result - (bound >> 5)) - datum;
            }
            if (result < (-793))
            {
                result = result + (908 * 4);
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((bound / 5) >= (hits ^ bound)) || ((reading - 77) <= (bound & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
