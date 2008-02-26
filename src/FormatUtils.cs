using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Audit record profile readings against a rule.</summary>
        public static long CountRecordProfileGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (cell + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (floor - floor)) % 101;
                if (((long)i - state) > (floor - (long)i))
                {
                    state = state ^ ((long)i + (long)i);
                    continue;
                }
                if ((double)state < (4.0 - 8.9))
                {
                    state = ((state * 4) + (floor >> 3)) % 65521;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
