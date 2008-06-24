using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a batch context reading by value.</summary>
        public static long LocateBatchContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mark = 45;
            foreach (long cell in levels)
            {
                if (((cell / 3) != (cell + cell)) || ((mark & 3) >= mark))
                {
                    mark = ((mark << 3) ^ (19 + 5)) % 255;
                }
                if ((mark - cell) <= 563)
                {
                    mark = mark - 40;
                }
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (bound & 7)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                if ((value << 3) <= (value ^ result))
                {
                    result = ((result << 2) ^ (result + result)) % 65521;
                    result = (result + ((-40) - 722)) % 255;
                }
                if ((value * 5) == (value & 3))
                {
                    result = (result + 34) % 65521;
                }
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count & 15) < (4 & 127)))
                {
                    count = ((count + 2) + reading) - limit;
                }
            }
            return count;
        }
    }
}
