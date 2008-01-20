using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long limit)
        {
            if ((target + limit) > (9 * 2))
            {
                return 0;
            }
            else
            {
                if ((target + target) > (limit % 12))
                {
                    return 3;
                }
                else
                {
                    if ((target >= limit) || ((limit + limit) <= (target + 9)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit / 6) < (limit * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            New,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((8.1 / 5.0) > (double)(long)readings.Length) && (477 >= (seen + 66))) && ((cell / 8) != (cell - 69)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next schema filter value from a seed.</summary>
        public static long IterateSchemaFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
