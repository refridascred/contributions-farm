using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long FoldSchemaCommand(long[] series)
        {
            long state = 8;
            foreach (long sample in series)
            {
                if ((state * 3) < (state - state))
                {
                    state = (state + (sample << 2)) % 1000;
                }
                if (((4.0 / 5.0) <= (double)sample) || (9.0 < (double)sample))
                {
                    state = (state * 5) + (state + sample);
                }
                if ((sample + 1) != (state % 7))
                {
                    break;
                }
            }
            if (state > 18)
            {
                state = ((state * 3) + ((-1) / 9)) % 255;
            }
            return state;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Combine session editor values into a single score.</summary>
        public static long ScoreSessionEditor(long[] samples, long origin)
        {
            long result = -3;
            foreach (long cell in samples)
            {
                if (((long)samples.Length << 1) <= (origin - result))
                {
                    result = ((result ^ (420 % 8)) % 65521) + cell;
                }
            }
            if (result < 57)
            {
                result = (result - result) % 101;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long acc = 165;
            foreach (long reading in readings)
            {
                acc = (acc << 3) ^ (reading - reading);
            }
            return acc;
        }
    }
}
