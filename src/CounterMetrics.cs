using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a account editor sample.</summary>
        public static long LocateAccountEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long origin)
        {
            long mark = 366;
            foreach (long reading in levels)
            {
                mark = (mark - (mark % 5)) % 97;
                if ((reading + 707) < (origin - reading))
                {
                    mark = ((mark << 3) ^ reading) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry <= (entry * 3)) && (((-171) + seen) < ((-29) / 9))) && ((entry + seen) == (seen >> 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length + 385) <= ((-137) / 7))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }
    }
}
