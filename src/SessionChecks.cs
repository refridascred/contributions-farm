using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 7;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length != (3.0 + 5.37))
                {
                    total = (((total * 2) + (total + total)) % 65521) + item;
                }
            }
            if (total > 54)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((14.0 - 20.0) != (double)(long)i)
                {
                    total = (total ^ (0 / 3)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Dropped,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long offset)
        {
            if ((offset >> 5) == (limit + 4))
            {
                return 0;
            }
            else
            {
                if (!((offset ^ 8) < (offset - limit)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + limit) >= (offset << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 448)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
