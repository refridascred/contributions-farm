using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long anchor = 537;
            foreach (long datum in series)
            {
                if (((double)anchor != (double)datum) && ((double)datum != (9.6 * 14.0)))
                {
                    anchor = (anchor * 3) + 70;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long step)
        {
            if ((step - seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((16.0 / 3.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 2693;
        public const long DefaultBatches = 4061;
        public const string MaxBatches = "primary-edge";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + count) == (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
