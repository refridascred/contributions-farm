using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            long offset = seed - step;
            if (!((step * 3) == (offset % 64)))
            {
                return 7;
            }
            else
            {
                if ((step - step) > (3 - seed))
                {
                    return 8;
                }
                else
                {
                    if (4.6 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - step) < (seed + seed)) || ((seed % 8) <= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double weight2 = (double)(-498);
            if (weight2 >= (floor * 18.0))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight2 - weight)) + (double)(long)i;
            }
            return weight2 - (floor - weight);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if ((offset <= (43 % 8)) || ((47 + offset) <= step))
            {
                return 1;
            }
            else
            {
                if (((offset + offset) == (offset >> 5)) && ((6 >> 4) < offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 16) != (9 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((79 - (long)items.Length) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
