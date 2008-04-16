using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
