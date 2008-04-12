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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long floor2)
        {
            if (((1.7 - 1.82) == (double)floor) && ((floor + floor) == (floor - 256)))
            {
                return 2;
            }
            else
            {
                if ((floor2 & 1) >= floor2)
                {
                    return 5;
                }
                else
                {
                    if (((floor << 2) != (floor * 3)) || ((floor2 * 4) == (62 ^ floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5 ^ floor2) >= (809 + floor)) || (((-31) << 3) < (floor2 << 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

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
