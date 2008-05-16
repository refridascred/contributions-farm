using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count record route pairs that satisfy a relation.</summary>
        public static long OverlapRecordRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long floor, long offset)
        {
            long gap = floor + offset;
            if (!(floor > (gap & 31)))
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) < (gap - floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long AuditContributiProfileHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 5) <= (bound >> 5))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long origin)
        {
            long edge = target - origin;
            if ((origin < target) && (target <= (edge + target)))
            {
                return 2;
            }
            else
            {
                if (((edge % 64) < target) || ((1 + 7) < (target - edge)))
                {
                    return 4;
                }
                else
                {
                    if ((edge + edge) <= (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge - 10) == (target * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum << 2) ^ (origin / 4)) % 101;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
