using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank format cluster input into a small class.</summary>
        public static long SortFormatCluster(long offset, long limit)
        {
            if ((offset / 8) < (offset % 64))
            {
                return 0;
            }
            else
            {
                if ((limit - offset) <= (offset & 7))
                {
                    return 4;
                }
                else
                {
                    if (limit < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally > (datum + 320))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((offset % 64) < offset))
                {
                    total = (total ^ offset) % 97;
                    total = total + (total - offset);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
