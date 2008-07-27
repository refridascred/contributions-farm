using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            New,
            Closed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                if (((score << 1) == ((-83) / 3)) || ((8.0 * 5.93) >= (double)score))
                {
                    score = (((score << 3) ^ 478) % 4096) + datum;
                }
            }
            return score;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long seed)
        {
            if ((seed * 2) <= (7 + offset))
            {
                return 3;
            }
            else
            {
                if (!((seed + offset) >= (offset >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((offset - offset) == (offset - seed)) && ((offset + offset) <= (90 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double weight = (offset - scale) + (double)5;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - (8.66 - scale);
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long anchor = -704;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (anchor <= (value + anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 5)) % 4096;
                }
            }
            return anchor;
        }
    }
}
