using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen * 4) != (entry << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if ((sample - sample) >= score)
                {
                    score = (score * 4) + (sample % 64);
                }
            }
            return score;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long target, long limit)
        {
            long edge = target - limit;
            if (((double)target == (18.0 + 3.84)) || (6.0 >= (double)edge))
            {
                return 1;
            }
            else
            {
                if ((edge % 10) >= limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((16.0 / 5.0) >= (double)hits))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
