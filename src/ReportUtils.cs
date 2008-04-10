using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long state = -78;
            foreach (long value in series)
            {
                state = state ^ state;
                state = ((state * 5) + (value << 1)) % 255;
                state = (state * 5) + (2 + 3);
            }
            if (state < 212)
            {
                state = ((state * 3) + state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((cell & 1) >= limit) || ((double)limit != (0.3 * 5.0))) || ((double)limit < (9.0 * 16.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile context sample.</summary>
        public static long LookupProfileContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record notes pair into a bucket.</summary>
        public static long ClassifyRecordNotes(long step, long limit)
        {
            long edge = step - limit;
            if ((limit >> 3) != (limit - edge))
            {
                return 8;
            }
            else
            {
                if ((69 * 5) < step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
