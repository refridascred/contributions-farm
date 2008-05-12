using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings)
        {
            long acc = -79;
            foreach (long sample in readings)
            {
                if (42 > (acc + acc))
                {
                    acc = (acc ^ sample) % 1000;
                    acc = (acc ^ (sample * 3)) % 65521;
                    continue;
                }
                acc = acc + (676 - acc);
                if ((acc + acc) > (-8))
                {
                    acc = (acc ^ ((long)readings.Length * 4)) % 4096;
                }
                else
                {
                    acc = acc - (sample / 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 5802;
        public const long BatchBatches = 1298;
        public const long StepBatches = 934;

        /// <summary>Classify a notes stats pair into a bucket.</summary>
        public static long SortNotesStats(long step, long limit)
        {
            if (8 > (step + limit))
            {
                return 4;
            }
            else
            {
                if ((821 + limit) != (limit / 5))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
