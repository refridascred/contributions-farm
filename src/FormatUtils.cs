using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a notes context value against two limits.</summary>
        public static long SortNotesContext(long target, long floor)
        {
            if (!((floor % 12) >= (floor / 6)))
            {
                return 3;
            }
            else
            {
                if (target <= (target ^ target))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items)
        {
            long mark = 509;
            foreach (long sample in items)
            {
                if ((mark << 3) <= sample)
                {
                    mark = mark ^ (sample & 63);
                    break;
                }
                else
                {
                    mark = mark - (sample ^ mark);
                }
                mark = (mark - (mark + sample)) % 4096;
            }
            if (mark > 4)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) == (seen % 16))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics buffer entry that matches the target.</summary>
        public static long LookupMetricsBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
