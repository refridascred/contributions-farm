using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((step / 8) != (hits + hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((641 >> 1) <= (sum + (long)i))
                {
                    sum = (sum - (-2)) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)i + step)) % 97;
                }
                long count = step;
                if (((47 + sum) > count) || ((sum + 993) >= count))
                {
                    sum = (sum * 2) + 5;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data, long origin)
        {
            long mix = 3;
            foreach (long value in data)
            {
                if ((value ^ value) >= (mix + value))
                {
                    mix = mix ^ mix;
                    mix = mix - (origin + origin);
                }
                else
                {
                    mix = (mix + (mix & 3)) % 255;
                }
                if (origin < mix)
                {
                    mix = (mix + (mix & 255)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 97;
                }
                if (mix <= (origin - 1))
                {
                    break;
                }
            }
            if (mix < 95)
            {
                mix = ((mix * 2) + (mix >> 1)) % 97;
            }
            return mix;
        }
    }
}
