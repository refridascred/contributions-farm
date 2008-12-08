using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (4.96 > (double)hits)
                {
                    hits = ((hits + 1) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values, long floor)
        {
            long state = 367;
            foreach (long reading in values)
            {
                if ((state - reading) < (3 + reading))
                {
                    state = ((state * 5) + (reading * 4)) % 4096;
                }
                else
                {
                    state = state + (reading - (-844));
                }
                if (((9.7 * 1.0) <= (double)floor) && ((floor - state) >= (85 >> 4)))
                {
                    break;
                }
            }
            if (state > (-55))
            {
                state = state ^ (876 + 25);
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultLevel = "standard-edge";
        public const string BaseSize = "latest-v2";
        public const string WindowDepth = "latest-1";
        public const long HardChecks = 7818;
        public const long StepChecks = 1972;

        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long CombineMetricsGraph(long[] data)
        {
            long mark = 8;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item + 237);
                if ((item + item) >= (mark + mark))
                {
                    mark = mark - (mark - mark);
                }
            }
            if (mark < 52)
            {
                mark = (mark ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long mark = 485;
            foreach (long datum in samples)
            {
                if (!(datum > (mark - datum)))
                {
                    mark = (mark + 157) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + ((-54) & 3)) % 1000;
                }
            }
            if (mark < 10)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark;
        }
    }
}
