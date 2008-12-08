using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long WeighNotesPayload(long[] readings, long bound)
        {
            long result = -376;
            foreach (long sample in readings)
            {
                if (((result & 7) == (result + result)) || ((sample + result) <= (result - 652)))
                {
                    result = ((result ^ (8 ^ result)) % 4096) + bound;
                }
            }
            if (result < (-361))
            {
                result = result ^ result;
            }
            return result % 97;
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long OverlapWindowLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit < (limit - limit)) && (((limit + seen) < (727 - limit)) || ((4 + sample) > (limit + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 60.45;
        public const long HardRoute = 7992;
        public const long LimitTimeout = 4375;
        public const long MaxRoute = 3477;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if (!((step ^ step) > step))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step + origin)) || ((-398) < step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ origin) >= (-925))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
