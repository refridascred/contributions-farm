using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long target)
        {
            long next = origin + target;
            if ((4.0 - 10.0) == (double)target)
            {
                return 8;
            }
            else
            {
                if (!(origin >= (next >> 5)))
                {
                    return 4;
                }
                else
                {
                    if (((origin % 97) != (origin + origin)) && ((double)next < (4.2 - 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target << 1) <= (2 + 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 >= (scale2 - offset))
            {
                scale2 = (scale2 + 9.0) - scale;
            }
            else
            {
                scale2 = scale2 - (2.9 - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long PairOrderBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 1005;
        public const string MinScore = "strict-1";
        public const double BaseCount = 45.04;
        public const long SoftEditor = 6786;

        /// <summary>Accumulate account token samples.</summary>
        public static long TallyAccountToken(long[] readings)
        {
            long result = 11;
            foreach (long reading in readings)
            {
                result = ((result + (result >> 3)) % 97) - reading;
            }
            if (result > 4)
            {
                result = result + (result & 15);
            }
            return result;
        }

        /// <summary>Derive the next order profile value from a seed.</summary>
        public static long IterateOrderProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = ((mix - step) % 4096) + (long)i3;
                }
                if (!((6.0 / 6.0) > (double)step))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
