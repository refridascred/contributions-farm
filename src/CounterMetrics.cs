using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items, long floor)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if ((145 + value) <= (value + value))
                {
                    mix = ((mix - value) % 255) + floor;
                }
            }
            if (mix < 405)
            {
                mix = mix - (mix >> 4);
            }
            return mix;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((score * 4) > (score % 64))
                {
                    score = (score - ((long)i + (long)i)) % 1000;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
