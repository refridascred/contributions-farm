using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double floor)
        {
            double ratio = floor * 4.0;
            if (ratio >= floor)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - (scale / 7.0);
            }
            return ratio + (double)789;
        }

        /// <summary>Match up route schema samples.</summary>
        public static long MatchRouteSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache record entries.</summary>
        public static long CombineCacheRecord(long[] items)
        {
            long total = 30;
            foreach (long value in items)
            {
                total = ((total * 2) + ((-4) ^ (long)items.Length)) + value;
            }
            return total;
        }

        /// <summary>Classify a checks farm pair into a bucket.</summary>
        public static long ClassifyChecksFarm(long bound, long offset)
        {
            if ((57 / 4) <= bound)
            {
                return 4;
            }
            else
            {
                if (9 >= (4 - bound))
                {
                    return 2;
                }
                else
                {
                    if ((9 >> 3) < (bound + offset))
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

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Failed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((6.0 < (double)target) && ((seen * 5) != (target - seen))) || ((83 - cell) == (cell - 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
