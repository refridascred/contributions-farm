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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
