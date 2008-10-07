using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series, long offset)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry + (offset >> 5)) - entry;
            }
            return carry;
        }

        /// <summary>Iterate the schema payload series from a seed.</summary>
        public static long DeriveSchemaPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((2 << 1) < (floor - floor))
                {
                    sum = sum + (52 >> 3);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (((double)step < 5.42) || ((step % 16) == (long)i))
                {
                    mix = ((mix << 2) ^ step) % 97;
                }
                mix = (mix + (long)i) % 4096;
                mix = mix - (mix & 31);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
