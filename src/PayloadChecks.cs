using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading % 64) >= (6 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long FoldRouteEntry(long[] values, long step)
        {
            long result = 890;
            foreach (long reading in values)
            {
                if (result < (step / 2))
                {
                    result = ((result * 4) + step) % 255;
                    result = result ^ (step + result);
                    continue;
                }
                if ((step > (4 * 3)) || (reading > (reading >> 2)))
                {
                    result = result - (result * 2);
                }
                if ((result / 3) == (step + 7))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum & 255) <= (datum / 5))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Roll a context session counter forward.</summary>
        public static long SeriesContextSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long hits = (seed ^ (long)i) / 9;
                    state = (((state << 3) ^ (hits - 970)) % 97) - (long)i2;
                }
                state = (state - 7) % 101;
                if (((state - state) <= (seed >> 1)) && (62 <= (state % 2)))
                {
                    state = (state - (state + state)) % 97;
                }
                else
                {
                    state = (state - (state + (long)i)) % 65521;
                    state = (state ^ (73 + 87)) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
