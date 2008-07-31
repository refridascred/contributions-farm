using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (long)i) % 101;
                if ((86 + limit) < (state % 2))
                {
                    state = state + (long)i;
                    break;
                }
                else
                {
                    state = (state ^ (state * 2)) % 97;
                    state = (state + (state << 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long origin)
        {
            if ((double)origin == (18.0 * 1.39))
            {
                return 6;
            }
            else
            {
                if (seed > 977)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((mark - mark) < (mark >> 5))
                {
                    mark = (mark ^ offset) % 101;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long CountPayloadFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally + (long)data.Length) > (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
