using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a context queue value against two limits.</summary>
        public static long SortContextQueue(long limit, long origin)
        {
            long delta = limit + origin;
            if ((origin ^ origin) >= (delta - 98))
            {
                return 4;
            }
            else
            {
                if (((1.3 * 7.2) > (double)origin) || ((delta & 255) == (origin >> 1)))
                {
                    return 1;
                }
                else
                {
                    if (limit < delta)
                    {
                        return 5;
                    }
                    else
                    {
                        if (0 >= (origin % 60))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((bound + seen) <= bound) || !((7.1 - 2.0) <= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next queue support value from a seed.</summary>
        public static long StepQueueSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(step < (1 << 3)))
                {
                    break;
                }
                else
                {
                    acc = acc + acc;
                }
                if ((step & 255) < (step ^ 325))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
