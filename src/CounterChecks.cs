using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mix = 975;
            foreach (long sample in readings)
            {
                if (((sample * 3) != (sample + sample)) && ((mix & 7) >= sample))
                {
                    break;
                }
                mix = mix ^ sample;
                if (mix < (mix + sample))
                {
                    mix = (mix * 5) + (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                state = (state << 2) ^ offset;
                if ((cell + cell) <= cell)
                {
                    state = (state << 3) ^ (cell * 4);
                }
                else
                {
                    state = ((state * 5) + offset) % 255;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (offset - offset)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long TallyContextSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((9.57 + 5.96) > (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long origin)
        {
            long total = 240;
            foreach (long value in data)
            {
                total = ((((total << 2) ^ (405 % 97)) % 101) + value) + origin;
            }
            return total;
        }
    }
}
