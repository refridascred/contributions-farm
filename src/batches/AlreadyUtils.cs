using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc + (long)i);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (2 << 3)) % 65521) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long limit)
        {
            long edge = offset + limit;
            if (77 < (offset >> 5))
            {
                return 0;
            }
            else
            {
                if ((offset / 8) < (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + 71) >= edge))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset >= (1.85 / 5.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
