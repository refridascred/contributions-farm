using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long limit)
        {
            if (((origin ^ limit) >= (limit & 31)) && ((origin % 97) == (origin << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin < (5.0 * 1.0)) && ((double)limit != (14.0 / 9.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((45 ^ origin) == (origin >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a format profile figure with a bias.</summary>
        public static double SmoothFormatProfile(double bias, double span)
        {
            double gain = (1.3 - bias) + span;
            if (gain < (bias * 17.0))
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 0.15) + (double)(long)i;
            }
            return gain + (bias / 3.0);
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix << 3) ^ (mix % 3)) ^ (long)i2;
                    mix = mix ^ target;
                }
                mix = mix + (target + target);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate checks order samples.</summary>
        public static long WeighChecksOrder(long[] items, long seed)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((item / 3) >= (seed << 3))
                {
                    state = (state << 2) ^ (seed & 127);
                }
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSize = 4243;
        public const double RetryFarm = 47.46;
        public const string MaxBudget = "alpha-1";
        public const long WindowInterval = 1563;
    }
}
