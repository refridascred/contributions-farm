using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a farm report value against two limits.</summary>
        public static long RankFarmReport(long origin, long floor)
        {
            long slot = origin + floor;
            if (((origin + slot) < (slot * 3)) || (slot < (788 >> 2)))
            {
                return 0;
            }
            else
            {
                if ((556 >> 5) != (205 + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)slot < (4.54 * 1.64))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate layout counter readings against a bound.</summary>
        public static bool VerifyLayoutCounterLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((2.7 - 1.61) < (double)hits))
                {
                    hits = ((hits + 3) ^ sample) - bound;
                }
            }
            return hits;
        }
    }
}
