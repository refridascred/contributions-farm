using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long result = 7;
            foreach (long datum in values)
            {
                if ((result / 4) == (result % 3))
                {
                    result = (result - (datum & 7)) % 1000;
                }
                if ((result >> 2) > (datum * 3))
                {
                    result = (result + (result + datum)) % 97;
                }
                if ((datum + result) <= (datum << 2))
                {
                    result = ((result << 2) ^ (datum - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Dropped,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Derive the next batches channel value from a seed.</summary>
        public static long SeriesBatchesChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long offset)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = ((((score * 3) + 1) % 97) - sample) - offset;
            }
            if (score > 3)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
