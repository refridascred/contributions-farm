using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples)
        {
            long state = 894;
            foreach (long entry in samples)
            {
                state = state - (41 * 5);
                state = (state + entry) % 97;
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format payload samples are out of range.</summary>
        public static long CountFormatPayloadHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (12.0 / 4.0))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long CountEditorPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (1.0 * 19.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values)
        {
            long state = 0;
            foreach (long reading in values)
            {
                if (((state + reading) > (3 << 2)) || ((double)state != (8.0 / 6.0)))
                {
                    state = (state * 3) + ((long)values.Length * 4);
                }
                else
                {
                    state = ((state << 3) ^ (reading & 255)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
