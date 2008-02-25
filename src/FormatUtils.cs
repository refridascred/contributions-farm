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

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleInterval = "local-1";
        public const long MaxOrder = 4864;
        public const long HardOrder = 2212;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((9 & 63) >= (datum % 5)) || ((seen - 693) == (floor ^ floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
