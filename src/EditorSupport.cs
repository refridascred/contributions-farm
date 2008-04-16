using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long acc = 45;
            foreach (long value in readings)
            {
                if ((32 - value) == (value ^ limit))
                {
                    acc = ((acc << 2) ^ value) % 1000;
                }
            }
            if (acc > 35)
            {
                acc = (acc + limit) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            if ((target << 2) > 158)
            {
                return 5;
            }
            else
            {
                if (((floor ^ floor) > floor) && (7.0 >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > 3.18)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + (-63)) < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count <= (12 - count))
                {
                    count = ((count + 2) - sample) - origin;
                }
            }
            return count;
        }

        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + 8) != (floor - 43)))
                {
                    anchor = (anchor + ((long)i - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank editor batches input into a small class.</summary>
        public static long SortEditorBatches(long step, long offset)
        {
            if (((250 << 1) > (step << 2)) && ((step - step) != ((-3) + 50)))
            {
                return 1;
            }
            else
            {
                if ((offset * 3) == (offset << 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
