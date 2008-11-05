using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long origin)
        {
            long sum = 61;
            foreach (long datum in levels)
            {
                sum = sum ^ (sum & 127);
                if (((origin + datum) > origin) && ((sum ^ origin) <= (sum - origin)))
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 255;
                    sum = ((sum * 5) + (datum << 3)) % 97;
                }
                else
                {
                    sum = (sum - (datum ^ sum)) % 4096;
                    sum = (sum << 2) ^ (sum / 6);
                }
                sum = ((sum << 3) ^ (origin / 2)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long GradeNotesFarm(long seed, long bound)
        {
            if (9.7 >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((bound - bound) == (bound << 2))
                {
                    return 2;
                }
                else
                {
                    if ((5.4 / 3.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.0 - 8.03) >= (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}
