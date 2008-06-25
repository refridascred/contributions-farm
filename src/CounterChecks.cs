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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((seed - hits) <= (hits + hits)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
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

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long StepChecksSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((39 < ((long)i + 834)) && ((double)(long)i > (double)carry))
                {
                    carry = ((carry * 3) + (seed ^ carry)) % 4096;
                }
                else
                {
                    carry = (carry - (carry << 2)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
