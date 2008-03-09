using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 7794;
        public const double LimitLevel = 15.98;
        public const long LimitFactor = 9584;
        public const long BatchContributi = 6440;
        public const long BurstContributi = 3743;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache farm series from a seed.</summary>
        public static long IterateCacheFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (floor + mix)) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every token order entry stays within the limit.</summary>
        public static bool CheckTokenOrderBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((7.2 * 1.13) >= (double)item) || ((count << 1) < item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
