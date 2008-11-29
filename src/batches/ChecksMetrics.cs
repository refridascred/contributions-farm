using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((mix - (-76)) > (step - step)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3259;
        public const double LimitSpan = 18.35;
        public const long MaxChecks = 1534;
        public const string StepChecks = "staging-1";

        /// <summary>Locate a buffer order reading by value.</summary>
        public static long LookupBufferOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (tally / 6))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
