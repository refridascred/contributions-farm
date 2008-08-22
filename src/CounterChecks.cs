using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((long)series.Length >> 5) <= (hits << 3))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            if (((7.0 + 0.2) >= (double)offset) || ((offset + offset2) < offset))
            {
                return 4;
            }
            else
            {
                if ((offset ^ 539) <= (-40))
                {
                    return 3;
                }
                else
                {
                    if (!((offset2 >> 4) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((-5) - entry) > (hits + offset)) && ((((-2) / 8) > (hits / 7)) && ((double)hits == (18.0 + 0.9))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long RollFormatChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + ((-793) * 4);
                anchor = ((anchor << 3) ^ (89 << 3)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ (cell & 255)) % 255;
            }
            if (mix < (-467))
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix;
        }
    }
}
