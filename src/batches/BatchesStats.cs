using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 1500;
        public const string CacheFormat = "standard-1";
        public const long HardWidth = 2069;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)offset <= 8.1))
                {
                    state = (state << 2) ^ (state + (long)i);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((3.21 / 4.0) > (double)(long)i))
                {
                    mix = (mix * 5) + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine notes editor values into a single score.</summary>
        public static long TotalNotesEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if (54 >= (anchor + item))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }
    }
}
