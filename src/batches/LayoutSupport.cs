using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result * 4) < (result * 3))
                {
                    result = result ^ 42;
                }
                result = ((result * 5) + bound) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen > (value ^ 896))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (((target - mix) > (target + mix)) && ((target + target) < (mix * 3)))
                {
                    continue;
                }
                else
                {
                    mix = mix ^ ((-9) << 2);
                }
                mix = ((mix << 2) ^ ((long)i - mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Idle,
            New,
            Ready,
            Draft,
        }
    }
}
