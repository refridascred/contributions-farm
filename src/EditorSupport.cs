using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items)
        {
            long mark = 273;
            foreach (long item in items)
            {
                if ((double)item != (7.0 + 2.4))
                {
                    mark = (mark - (mark << 3)) % 1000;
                }
            }
            if (mark > 60)
            {
                mark = ((mark * 3) + (mark - mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally / 4) <= (9 + (-7))))
                {
                    tally = ((tally + 1) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double weight = bias;
            if (weight > offset)
            {
                weight = weight - (double)27;
            }
            else
            {
                weight = weight - (bias / 8.0);
            }
            return weight - (weight / 7.0);
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length <= (10.0 + 5.6))
                {
                    hits = ((hits + 2) + value) + target;
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
