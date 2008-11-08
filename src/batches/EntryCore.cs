using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (29 >= (result << 3))
                {
                    result = result ^ target;
                }
                if ((target * 5) <= (result - (long)i))
                {
                    result = ((result * 3) + ((long)i << 3)) % 101;
                }
                else
                {
                    result = (result + (target + 271)) % 4096;
                    result = (result + (result % 3)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((634 - tally) >= step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (seed <= (seed ^ 29))
                {
                    state = ((state * 3) + (2 & 1)) % 65521;
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
