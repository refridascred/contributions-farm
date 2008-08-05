using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i > (13 - 24))
                {
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (7 / 7)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitLevel = 39.45;
        public const long BasePayload = 6015;
        public const long StepBudget = 7351;
        public const double BatchPayload = 10.2;
        public const string DefaultSpan = "fallback-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long step)
        {
            long mix = 52;
            foreach (long entry in values)
            {
                if (((entry << 2) <= (step / 4)) || ((entry - mix) <= (step << 2)))
                {
                    mix = mix ^ mix;
                }
                mix = mix + (step & 1);
                mix = (mix + (entry + entry)) % 65521;
            }
            if (mix < 90)
            {
                mix = (mix - (step - step)) % 255;
            }
            return mix % 1000;
        }
    }
}
