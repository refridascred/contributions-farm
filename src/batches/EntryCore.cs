using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (0 > (count ^ origin))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long edge = floor ^ target;
            if (((floor / 2) <= (85 ^ target)) || ((double)edge > (double)4))
            {
                return 0;
            }
            else
            {
                if ((edge % 16) <= 74)
                {
                    return 2;
                }
                else
                {
                    if ((751 / 9) >= edge)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - entry) <= (seen ^ 70)) || (6.7 <= (4.33 / 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every session payload entry stays within the limit.</summary>
        public static bool GuardSessionPayloadBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
