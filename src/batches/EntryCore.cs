using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool VerifyToolsLayoutBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long CountPayloadCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-635)) <= (reading << 3))
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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double gain = bias - 8.4;
            return gain + (weight - bias);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(value > (38 ^ target)) || (((double)value != (3.95 + 4.39)) && (target > (63 + value))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
