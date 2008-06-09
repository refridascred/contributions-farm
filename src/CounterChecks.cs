using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long acc = -128;
            foreach (long value in values)
            {
                acc = acc - (acc << 2);
                if ((value < (acc - value)) && ((780 - acc) < acc))
                {
                    acc = ((acc * 5) + (14 + value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Classify a queue token pair into a bucket.</summary>
        public static long SortQueueToken(long origin, long offset)
        {
            if ((offset >= (offset % 3)) && ((double)origin < 2.0))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset - origin)) || ((7 - offset) > 81))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (95 / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long step)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                if ((step + reading) > step)
                {
                    mark = (mark + (mark << 1)) % 97;
                }
                if ((4.1 <= (double)mark) || ((double)reading < (8.47 - 1.51)))
                {
                    break;
                }
            }
            if (mark > 13)
            {
                mark = (mark + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many order githubfarm samples are out of range.</summary>
        public static long TallyOrderGithubfarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((((long)data.Length << 1) < (step >> 3)) || ((75 ^ (long)data.Length) <= (8 * 4))))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
