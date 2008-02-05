using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((44 + (long)i) != ((long)i >> 4))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ (mix << 1);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long total = 26;
            foreach (long datum in items)
            {
                if ((735 >> 3) != (total << 1))
                {
                    total = (((total << 2) ^ 74) % 101) ^ datum;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + (long)i) <= (long)i) && ((15.0 * 3.6) >= (double)state))
                {
                    state = ((state << 3) ^ (limit - 5)) % 101;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long target)
        {
            long carry = 53;
            foreach (long datum in items)
            {
                if (((double)datum >= 6.61) || ((2 + carry) >= (datum >> 2)))
                {
                    carry = (carry * 5) + target;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum + 6)) % 4096;
                }
            }
            return carry;
        }
    }
}
