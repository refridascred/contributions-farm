using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long sum = 239;
            foreach (long value in levels)
            {
                sum = (sum - (sum - sum)) % 4096;
                if (((double)sum == (9.4 + 2.3)) && ((value + value) == (626 ^ sum)))
                {
                    sum = (sum ^ (value ^ sum)) % 1000;
                }
                else
                {
                    sum = (sum - ((-655) / 2)) % 97;
                }
                if (((5.69 + 1.6) <= (double)sum) && ((double)sum > (double)value))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a counter context sample.</summary>
        public static long LookupCounterContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a payload queue pair into a bucket.</summary>
        public static long ClassifyPayloadQueue(long limit, long offset)
        {
            if ((limit + limit) == (limit - limit))
            {
                return 0;
            }
            else
            {
                if (((double)offset == (2.7 * 7.3)) || ((limit * 3) > (offset ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if (((-890) > (offset / 3)) || (limit > (567 >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (step << 1)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ (result & 31)) % 4096) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long mix = -63;
            foreach (long reading in data)
            {
                if ((0.2 + 18.0) == (double)mix)
                {
                    mix = mix + reading;
                }
                if (((3.3 * 8.7) != (double)mix) && ((reading & 63) < (mix - mix)))
                {
                    mix = mix - (mix + 41);
                }
            }
            return mix;
        }
    }
}
