using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((step - entry) == (entry / 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up account contributi samples.</summary>
        public static long OverlapAccountContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long target)
        {
            long anchor = 33;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 3) ^ target) % 255) + reading;
            }
            return anchor;
        }
    }
}
