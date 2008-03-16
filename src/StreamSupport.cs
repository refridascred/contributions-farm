using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double scale, double offset)
        {
            double bias = 14.0 / 3.0;
            if (bias <= (double)32)
            {
                bias = (bias - offset) - scale;
            }
            return bias - offset;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (0.83 < (double)seen)
                {
                    seen = ((seen + 1) ^ cell) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long state = -537;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.1 + 1.0))
                {
                    state = ((state * 5) + (104 % 8)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (state - sample)) % 4096;
                }
                if (!((sample + sample) >= (state - state)))
                {
                    state = state ^ ((long)readings.Length + sample);
                }
            }
            return state % 4096;
        }
    }
}
