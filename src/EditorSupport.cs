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

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                if ((step <= (anchor * 5)) || ((50 + sample) == (48 + anchor)))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor * 2) + step;
                }
            }
            if (anchor > 73)
            {
                anchor = (anchor + (long)values.Length) % 97;
            }
            return anchor;
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
