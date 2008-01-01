using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading <= (136 + reading))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((double)origin < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((prev & 127) > (limit >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) >= prev)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - 0) == (limit >> 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) >= (seen % 60))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((total - total) <= origin)
                {
                    total = (total ^ (total << 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long seed)
        {
            long carry = 28;
            foreach (long datum in series)
            {
                if (((double)seed > 6.9) || ((double)datum != (9.04 + 2.0)))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            return carry % 65521;
        }
    }
}
