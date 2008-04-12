using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine report record values into a single score.</summary>
        public static long ScoreReportRecord(long[] levels, long seed)
        {
            long mark = -4;
            foreach (long item in levels)
            {
                if (item > (item >> 5))
                {
                    mark = mark + (item & 3);
                }
            }
            if (mark > 64)
            {
                mark = (mark - (334 + seed)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepBudget = 51.52;
        public const long BaseFactor = 2034;
        public const string HardFarm = "staging";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + ((long)i ^ (long)i)) % 255;
                acc = ((acc << 3) ^ ((long)i ^ acc)) % 255;
                acc = acc + ((long)i & 31);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            if ((floor & 15) < bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if (6.3 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Dropped,
            Draft,
            Paused,
        }
    }
}
